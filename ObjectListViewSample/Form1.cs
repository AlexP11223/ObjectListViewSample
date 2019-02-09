using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BrightIdeasSoftware;
using ObjectListViewSample.Helpers;

namespace ObjectListViewSample
{
    public partial class Form1 : Form
    {
        // http://objectlistview.sourceforge.net/cs/recipes.html#isn-t-there-are-way-to-get-rid-of-all-the-casts-in-the-delegates
        private readonly TypedObjectListView<FileSystemItem> _tptvFilesystem;
        private readonly TypedColumn<FileSystemItem> _tpcolName;

        public Form1()
        {
            InitializeComponent();

            //Shown += (sender, args) => new Form2().Show();

            _tptvFilesystem = new TypedObjectListView<FileSystemItem>(tvFilesystem);
            _tpcolName = _tptvFilesystem.GetColumn("Name");

            SetupFsTreeView();
        }

        private void SetupFsTreeView()
        {
            tvFilesystem.CanExpandGetter = obj => ((FileSystemItem) obj).IsDir;
            tvFilesystem.ChildrenGetter = obj =>
            {
                try
                {
                    return ((FileSystemItem) obj).Children;
                }
                catch (UnauthorizedAccessException ex)
                {
                    // on error (e.g. restricted system dirs) show message box and collapse the subtree allowing the user to retry later
                    // we cannot do this immediately in this getter because TreeListView will not react correctly and may remain in undefined state
                    // so we use BeginInvoke to execute it a bit later on the UI thread
                    BeginInvoke(new Action(() =>
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        tvFilesystem.Collapse(obj);
                    }));
                    return new List<FileSystemItem>();
                }
            };
            tvFilesystem.ParentGetter = obj => ((FileSystemItem) obj).Parent;

            _tpcolName.ImageGetter = GetIconKey;

            colSize.AspectToStringConverter = val =>
            {
                long num = (long)val;
                return num < 0 ? String.Empty : StringHelper.FormatSize(num);
            };

            SetupNameEditing();

            // drive letters (C:\, D:\, etc.) in roots
            tvFilesystem.Roots = DriveInfo.GetDrives()
                .Where(d => d.IsReady)
                .Select(d => new FileSystemItem(d.Name));
        }

        private void SetupNameEditing()
        {
            // allow only name editing
            foreach (var col in tvFilesystem.AllColumns)
            {
                col.IsEditable = false;
            }
            colName.IsEditable = true;

            tvFilesystem.CellEditStarting += (sender, e) =>
            {
                var fsItem = (FileSystemItem) e.RowObject;

                // don't try to edit roots (drive letters)
                e.Cancel = fsItem.IsRoot;
            };
            // http://objectlistview.sourceforge.net/cs/cellEditing.html
            // we can just create writable Name property instead and it would set the property value automatically
            // but in this case we need to rename the file, handle/show errors
            _tpcolName.AspectPutter = (fsItem, value) =>
            {
                string newName = (string) value;

                if (newName == fsItem.Name)
                {
                    return;
                }

                string newFullPath = Path.Combine(fsItem.ParentFullPath, newName);
                if (FileHelper.FileOrDirExists(newFullPath))
                {
                    MessageBox.Show($"{newName} already exists in {fsItem.ParentFullPath}.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                try
                {
                    fsItem.Rename(newName);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            };
        }

        private string GetIconKey(FileSystemItem fsItem)
        {
            string path = fsItem.FullPath;

            if (fsItem.IsDir && !fsItem.IsRoot)
                path = System.Environment.SystemDirectory; // optimization, give all directories the same icon
            else if (Path.HasExtension(path))
                path = Path.GetExtension(path);

            if (imglstIcons.Images.ContainsKey(path))
                return path;

            AddImageToList(path, imglstIcons, ShellHelper.GetFileIcon(path, true, true));

            return path;
        }

        private void AddImageToList(string key, ImageList imageList, Icon icon)
        {
            if (imageList.ImageSize == icon.Size)
            {
                imageList.Images.Add(key, icon);
                return;
            }

            imageList.Images.Add(key, ImageHelper.Resize(icon.ToBitmap(), imageList.ImageSize));
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            var items = tvFilesystem.CheckedObjects;

            if (MessageBox.Show("Do you want to delete selected files?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                return;

            try
            {
                foreach (FileSystemItem item in items)
                {
                    if (item.IsRoot) 
                        continue;

                    item.Delete();

                    tvFilesystem.RemoveObject(item);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

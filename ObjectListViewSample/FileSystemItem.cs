using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using ObjectListViewSample.Helpers;

namespace ObjectListViewSample
{
    class FileSystemItem
    {
        private List<FileSystemItem> _children;

        public FileSystemItem(string rootPath)
        {
            Name = rootPath;
            IsDir = Directory.Exists(FullPath);
        }

        private FileSystemItem(FileSystemItem parent, string name)
        {
            Parent = parent;
            Name = name;
            IsDir = Directory.Exists(FullPath);
        }

        public string FullPath => Parent == null ? Name : Path.Combine(ParentFullPath, Name);

        public string Name { get; private set; }

        public string ParentFullPath => Parent?.FullPath;

        public FileSystemItem Parent { get; }

        public bool IsRoot => Parent == null;

        public bool IsDir { get; }

        public long Size => IsDir ? -1 : new FileInfo(FullPath).Length;

        public DateTime LastWriteTime => new FileInfo(FullPath).LastWriteTime;

        public List<FileSystemItem> Children
        {
            get
            {
                if (_children != null)
                {
                    return _children;
                }

                if (!IsDir)
                {
                    return new List<FileSystemItem>();
                }

                _children = Directory.GetFileSystemEntries(FullPath)
                    .Select(filePath => new FileSystemItem(this, Path.GetFileName(filePath)))
                    .ToList();

                return _children;
            }
        }

        public int Progress { get; set; } // not used (only for dummy progress bar demo)

        public void Rename(string newName)
        {
            if (IsRoot)
            {
                throw new InvalidOperationException("Cannot rename root");
            }

            if (newName == Name)
            {
                return;
            }

            string newFullPath = Path.Combine(ParentFullPath, newName);

            Directory.Move(FullPath, newFullPath);

            Name = newName;
        }

        public void Delete()
        {
            if (IsRoot || !FileHelper.FileOrDirExists(FullPath))
                return;

            if (IsDir)
            {
                FileHelper.DeleteDirWithFiles(FullPath);
            }
            else
            {
                File.Delete(FullPath);
            }

            Parent._children = null; // need to refresh
        }

        public override string ToString()
        {
            return Name;
        }
    }
}

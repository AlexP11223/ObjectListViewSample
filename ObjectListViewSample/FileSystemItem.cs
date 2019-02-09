using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using ObjectListViewSample.Helpers;

namespace ObjectListViewSample
{
    class FileSystemItem : ObservableObject
    {
        private string _name;
        private FileSystemItem _parent;
        private List<FileSystemItem> _children;

        public FileSystemItem(string rootPath)
        {
            Name = rootPath;
            IsDir = Directory.Exists(FullPath);
        }

        private FileSystemItem(FileSystemItem parent, string name)
        {
            _parent = parent;
            Name = name;
            IsDir = Directory.Exists(FullPath);
        }

        public string FullPath => _parent == null ? Name : Path.Combine(ParentFullPath, Name);

        public string Name
        {
            get => _name;
            private set
            {
                SetField(ref _name, value);
                OnPropertyChanged(nameof(FullPath));

                UpdateChildren();
            }
        }

        public string ParentFullPath => _parent?.FullPath;

        public FileSystemItem Parent => _parent;

        public bool IsRoot => _parent == null;

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

        private int _progress;
        public int Progress // not used (only for dummy progress bar demo)
        {
            get => _progress;
            set => SetField(ref _progress, value);
        }

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

            _parent._children = null; // need to refresh
        }

        public override string ToString()
        {
            return Name;
        }

        // probably not really needed since we don't bind to full paths
        private void UpdateChildren()
        {
            if (_children == null)
                return;

            foreach (var child in _children)
            {
                child.OnPropertyChanged(nameof(FullPath));
                child.OnPropertyChanged(nameof(ParentFullPath));
                child.UpdateChildren();
            }
        }
    }
}

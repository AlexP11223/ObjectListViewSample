using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ObjectListViewSample
{
    class FileSystemItem : ObservableObject
    {
        private List<FileSystemItem> _children;
        private string _fullPath;

        public FileSystemItem(string fullPath)
        {
            FullPath = fullPath;
            IsDir = Directory.Exists(FullPath);
            IsRoot = new DirectoryInfo(fullPath).Parent == null;
        }

        public string FullPath
        {
            get => _fullPath;
            private set
            {
                SetField(ref _fullPath, value);
                OnPropertyChanged(nameof(Name));
            }
        }

        public string Name => IsRoot? FullPath : Path.GetFileName(FullPath);

        public string ParentPath => IsRoot ? null : Path.GetDirectoryName(FullPath);

        public bool IsRoot { get; }

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
                    .Select(filePath => new FileSystemItem(filePath))
                    .ToList();

                return _children;
            }
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

            string newFullPath = Path.Combine(ParentPath, newName);

            Directory.Move(FullPath, newFullPath);

            FullPath = newFullPath;
            _children = null;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}

using System;
using System.Collections.Generic;

namespace ObjectListViewSample
{
    enum FileSystemItemType
    {
        Dir,
        File
    }

    class FileSystemItem
    {
        public string Name { get; set; }
        public long Size { get; set; } = -1;
        public DateTime WrittenDateTime { get; set; }
        public FileSystemItemType Type { get; set; } = FileSystemItemType.File;

        public List<FileSystemItem> Children { get; set; } = new List<FileSystemItem>();

        public override string ToString()
        {
            return Name;
        }
    }
}

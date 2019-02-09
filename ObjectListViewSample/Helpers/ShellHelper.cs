using System;
using System.Drawing;
using System.Runtime.InteropServices;

namespace ObjectListViewSample.Helpers
{
    static class ShellHelper
    {
        private const int SHGFI_ICON = 0x00100;  
        private const int SHGFI_SMALLICON = 0x00001;  
        private const int SHGFI_USEFILEATTRIBUTES = 0x00010;

        private const int FILE_ATTRIBUTE_NORMAL = 0x00080;
        private const int FILE_ATTRIBUTE_DIRECTORY = 0x00010;

        private const int MAX_PATH = 260;

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Auto)]
        private struct SHFILEINFO
        {
            public IntPtr hIcon;
            public int iIcon;
            public int dwAttributes;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = MAX_PATH)]
            public string szDisplayName;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 80)]
            public string szTypeName;
        }

        [DllImport("shell32.dll", CharSet = CharSet.Auto)]
        private static extern IntPtr SHGetFileInfo(string pszPath, int dwFileAttributes, out SHFILEINFO psfi, int cbFileInfo, int uFlags);

        /// <summary>
        /// Return the icon for the given file/directory.
        /// </summary>
        /// <param name="path">The full path to the file whose icon is to be returned</param>
        /// <param name="isSmallImage">True if the small (16x16) icon is required, otherwise the 32x32 icon will be returned</param>
        /// <param name="useFileType">If this is true, only the file extension will be considered</param>
        /// <returns>The icon of the given file, or null if something goes wrong</returns>
        public static Icon GetFileIcon(string path, bool isSmallImage, bool useFileType)
        {
            int flags = SHGFI_ICON;
            if (isSmallImage)
                flags |= SHGFI_SMALLICON;

            int fileAttributes = 0;
            if (useFileType)
            {
                flags |= SHGFI_USEFILEATTRIBUTES;
                fileAttributes = System.IO.Directory.Exists(path) ? FILE_ATTRIBUTE_DIRECTORY : FILE_ATTRIBUTE_NORMAL;
            }

            var shfi = new SHFILEINFO();
            IntPtr result = SHGetFileInfo(path, fileAttributes, out shfi, Marshal.SizeOf(shfi), flags);
            if (result.ToInt32() == 0)
                return null;
            return Icon.FromHandle(shfi.hIcon);
        }
    }
}

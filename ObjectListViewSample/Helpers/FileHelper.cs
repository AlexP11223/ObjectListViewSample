using System.IO;

namespace ObjectListViewSample.Helpers
{
    static class FileHelper
    {
        public static bool FileOrDirExists(string path)
        {
            return File.Exists(path) || Directory.Exists(path);
        }

        /// <summary>
        /// Deletes directory with all files inside
        /// </summary>
        /// <param name="dirPath">Directory path</param>
        public static void DeleteDirWithFiles(string dirPath)
        {
            DirectoryInfo dirInfo = new DirectoryInfo(dirPath);

            foreach (var file in dirInfo.GetFiles())
            {
                file.Delete();
            }

            Directory.Delete(dirPath);
        }
    }
}

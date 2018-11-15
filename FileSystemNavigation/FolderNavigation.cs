using System;
using System.IO;

namespace FileSystemNavigation
{
    public class FolderNavigation
    {
        private readonly string entryPath;
        private readonly string searchWord;
        private string currentPath;

        public FolderNavigation(string entryPath, string searchWord)
        {
            this.entryPath = entryPath;
            this.searchWord = searchWord;
            this.currentPath = entryPath;
        }

        public string GettingFolderName()
        {
            string[] foldersNames = entryPath.Split(new char[] { '\\' });

            return foldersNames[foldersNames.Length - 1];
        }

        public string MatchingPath()
        {
            string[] foldersNames = entryPath.Split(new char[] { '\\' });
            string currentFolder = foldersNames[foldersNames.Length - 1];
            if (currentFolder.Contains(this.searchWord))
            {
                this.WritingPathToFile(this.currentPath, "folder");
            }

            Environment.
        }

        public void WritingPathToFile(string currentPath, string flag)
        {
            using (StreamWriter streamWriter = new StreamWriter("MatchingPaths.txt"))
            {
                streamWriter.WriteLine(currentPath + " - " + flag);
            }
        }
    }
}

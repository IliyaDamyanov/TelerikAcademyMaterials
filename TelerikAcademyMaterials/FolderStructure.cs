using System;
using System.Collections.Generic;
using System.IO;
using TelerikAcademyMaterials.Contracts;
using TelerikAcademyMaterials.Utils;

namespace TelerikAcademyMaterials
{
    public class FolderStructure
    {
        private readonly IWriter writer;
        private readonly FileReader reader;
        private IDictionary<string, string> paths;

        public FolderStructure(IWriter writer, FileReader reader)
        {
            this.paths = new Dictionary<string, string>();
            this.writer = writer;
            this.reader = reader;
        }

        public IDictionary<string, string> AllPathsFinder(string entryFolder)
        {
            string currentFolder = entryFolder;

            try
            {
                foreach (string folder in Directory.GetDirectories(currentFolder))
                {
                    foreach (string file in Directory.GetFiles(folder))
                    {
                        if (file.Contains("Links"))
                        {
                            reader.FilePath = file;
                            string wordText = reader.Read();
                            this.YouTubeLinkFinder(wordText);
                            

                        }
                    }
                    AllPathsFinder(folder);
                }
            }
            catch (Exception exception)
            {
                this.writer.Write(exception.Message);

                throw new Exception("FolderStructure exception");
            }

            return paths;
        }

        public void YouTubeLinkFinder(string wordText)
        {
            int youtubeLinkStartIndex = wordText.IndexOf("https://www.youtube.com");
            int youtubeLinkEndIndex = wordText.IndexOf("</", youtubeLinkStartIndex);
            string youtubeLink = wordText.Substring(youtubeLinkStartIndex, youtubeLinkEndIndex - youtubeLinkStartIndex);

        }
    }
}

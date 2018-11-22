using System.IO;
using TelerikAcademyMaterials.Contracts;

namespace TelerikAcademyMaterials.Utils
{
    public class FileReader : IReader
    {
        protected readonly string filePath;

        public FileReader(string filePath)
        {
            this.filePath = filePath;
        }

        public virtual string Read()
        {
            string text = string.Empty;
            using (StreamReader streamReader = new StreamReader(this.filePath))
            {
                text = streamReader.ReadToEnd();
            }

            return text;
        }
    }
}

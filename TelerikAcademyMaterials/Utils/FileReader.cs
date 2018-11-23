using System.IO;
using TelerikAcademyMaterials.Contracts;

namespace TelerikAcademyMaterials.Utils
{
    public class FileReader : IReader
    {
        public string FilePath
        {
            get; set;
        }

        public virtual string Read()
        {
            string text = string.Empty;
            using (StreamReader streamReader = new StreamReader(this.FilePath))
            {
                text = streamReader.ReadToEnd();
            }

            return text;
        }
    }
}

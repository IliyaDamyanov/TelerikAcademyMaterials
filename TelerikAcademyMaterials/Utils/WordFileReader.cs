using DocumentFormat.OpenXml.Packaging;
using System.IO;

namespace TelerikAcademyMaterials.Utils
{
    public class WordFileReader : FileReader
    {
        public WordFileReader(string filePath) : base(filePath)
        {
        }

        public override string Read()
        {
            using (WordprocessingDocument wordDoc = WordprocessingDocument.Open(this.filePath, true))
            {
                using (StreamReader sr = new StreamReader(wordDoc.MainDocumentPart.GetStream()))
                {
                    string docText = sr.ReadToEnd();
                    return docText;
                }
            }
        }
    }
}
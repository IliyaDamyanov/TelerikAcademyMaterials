using DocumentFormat.OpenXml.Packaging;
using System.IO;

namespace TelerikAcademyMaterials.Utils
{
    public class WordFileReader : FileReader
    {
        public override string Read()
        {
            using (WordprocessingDocument wordDoc = WordprocessingDocument.Open(this.FilePath, true))
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
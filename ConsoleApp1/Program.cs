using DocumentFormat.OpenXml.Packaging;
using System.IO;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            using (WordprocessingDocument wordDoc = WordprocessingDocument.Open(@"C:\Users\IliyaDamyanov\Desktop\Links.docx", true))
            {
                using (StreamReader sr = new StreamReader(wordDoc.MainDocumentPart.GetStream()))
                {
                    string docText = sr.ReadToEnd();
                    using (StreamWriter streamWriter = new StreamWriter("txt.txt"))
                    {
                        streamWriter.Write(docText);
                    }
                }
            }
        }
    }
}

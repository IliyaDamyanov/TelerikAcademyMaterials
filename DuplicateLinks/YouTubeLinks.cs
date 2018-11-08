using DocumentFormat.OpenXml.Packaging;
using System.IO;
using System;

namespace DuplicateLinks
{
    public class YouTubeLinks
    {
        public void test()
        {
            using (WordprocessingDocument wordDoc = WordprocessingDocument.Open(@"C:\Users\IliyaDamyanov\Desktop\Links.docx", true))
            {
                using (StreamReader sr = new StreamReader(wordDoc.MainDocumentPart.GetStream()))
                {
                    string docText = sr.ReadToEnd();
                    int youtubeIndex = docText.IndexOf("youtube");
                    int indexOfRun = docText.IndexOf("</w:hyperlink>", youtubeIndex);
                    int indexOfInsert = indexOfRun + 14;
                    string newText = docText.Insert(indexOfInsert, "<w:t>kur</w:t>");
                    using (StreamWriter wr = new StreamWriter(wordDoc.MainDocumentPart.GetStream()))
                    {
                        wr.Flush();
                        wr.Write(newText);
                    }
                }
            }
        }
    }
}

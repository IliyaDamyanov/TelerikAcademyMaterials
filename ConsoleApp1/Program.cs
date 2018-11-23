using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;
using DuplicateLinks;
using FileSystemNavigation;
using System;
using System.IO;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //YouTubeLinks youTubeLinks = new YouTubeLinks();
            //youTubeLinks.test();

            //OpenAndAddTextToWordDocument(@"C:\Users\IliyaDamyanov\Desktop\Links.docx", "kur");
            string path = @"C:\Users\IliyaDamyanov\Desktop\TelerikAcademyMaterials\ConsoleApp1\bin\Debug";
            //string path = Console.ReadLine();
            asd navigation = new asd(path);
            Console.WriteLine(navigation.GettingFolderName());
        }

        public void WordReader()
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

        public static void OpenAndAddTextToWordDocument(string filepath, string txt)
        {
            // Open a WordprocessingDocument for editing using the filepath.
            WordprocessingDocument wordprocessingDocument = WordprocessingDocument.Open(filepath, true);

            // Assign a reference to the existing document body.
            Body body = wordprocessingDocument.MainDocumentPart.Document.Body;

            // Add new text.
            Paragraph para = body.AppendChild(new Paragraph());
            Run run = para.AppendChild(new Run());
            run.AppendChild(new Text(txt));

            // Close the handle explicitly.
            wordprocessingDocument.Close();
        }
    }
}

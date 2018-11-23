using TelerikAcademyMaterials.Utils;

namespace TelerikAcademyMaterials
{
    public class EntryPoint
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\iliya.damyanov\Desktop\Telerik";
            FolderStructure folderStructure = new FolderStructure(new ConsoleWriter(), new WordFileReader());
            folderStructure.AllPathsFinder(path);
        }
    }
}

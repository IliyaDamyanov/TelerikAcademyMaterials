using System;
using TelerikAcademyMaterials.Contracts;

namespace TelerikAcademyMaterials.Utils
{
    public class ConsoleWriter : IWriter
    {
        public void Write(string text)
        {
            Console.WriteLine(text);
        }
    }
}

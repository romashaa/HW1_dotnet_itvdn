using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class Author
    {
        private string authorName;

        public Author(string authorName)
        {
            this.authorName = authorName;
        }

        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"Author: {authorName}");
            Console.ResetColor();
        }
    }
}

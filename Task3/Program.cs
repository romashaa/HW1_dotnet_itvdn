using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book("MyBook", "I am author", "My book content.");

            book.ShowBookInfo();
            Console.ReadKey();
        }
    }
}

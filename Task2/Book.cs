using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class Book
    {
        private Title title;
        private Author author;
        private Content content;

        public Book(string bookTitle, string authorName, string bookContent)
        {
            title = new Title(bookTitle);
            author = new Author(authorName);
            content = new Content(bookContent);
        }

        public void ShowBookInfo()
        {
            title.Show();
            author.Show();
            content.Show();
        }
    }
}

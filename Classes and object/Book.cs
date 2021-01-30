using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_and_object
{
    class Book
    {
        public string title,author;
        public int pages;
        public Book(string aTitle,string aAuthor,int aPages)
        {
            title = aTitle;
            author = aAuthor;
            pages = aPages;
        }
    }
}

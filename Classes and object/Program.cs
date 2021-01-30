using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_and_object
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book("Harry Potter", "jK Rowling", 400);
            book1.title = "The hobbits";
            Book book3 = new Book("Study Big Data","Saya", 150);
            Console.WriteLine(book1.title +" " + book1.pages);
            Console.WriteLine(book3.author);
            Console.ReadLine();
        }
    }
}

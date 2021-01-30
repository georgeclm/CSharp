using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace structure
{
    class Program
    {
        public enum Days
        {
            Monday = 1, Tuesday = 2, Wednesday = 3, Thursday = 4, Friday = 5, Saturday = 6, Sunday = 7,
        };
        public enum Months
        {
            January = 1,February,March,April,May,June,July,August,Septmeber,October,November,December
        }
       
        struct Books
        {
            public string title;
            public string author;
            public string subject;
            public int book_id;
            public void printBook()
            {
                Console.WriteLine("Book title : {0}", title);
                Console.WriteLine("Book author : {0}", author);
                Console.WriteLine("Book subject : {0}", subject);
                Console.WriteLine("Book book_id :{0}", book_id);
            }
        };
        struct S
        {
            int aX;
            public int X
            {
                get { return aX; }
                set
                {
                    if (value < 10)
                    {
                        aX = value;
                    }
                    else
                    {
                        aX = 666;
                    }
                }
            }
        };
        static void Main(string[] args)
        {
            Console.Write("Input your day number: ");
            int theNum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine((Days)theNum);
            int myNum = (int)Months.April;
            Console.WriteLine("Your month is: " + myNum);
            S st = new S();
            st.X = 11;
            Console.WriteLine(st.X);
            Books Book1;
            Book1.title = "C Programming";
            Book1.author = "Johnson";
            Book1.subject = "C Programming Tutorial";
            Book1.book_id = 6495407;
            Book1.printBook();
            Student student1 = new Student();
            student1.name = "Jono";
            student1.major = "Information Technology";
            student1.grade = 3.5;
            student1.printStudent();
            Console.ReadLine();
        }
    }
}

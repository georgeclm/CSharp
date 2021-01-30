using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_Methods
{
    class Program
    {
        static void Main(string[] args)
        {

            Student student1 = new Student("George","Information Technology", 4.0);
            Student student2 = new Student("Budi", "Business", 3.2);
            Console.WriteLine(student1.Cumlaude());
            Console.WriteLine(student2.Cumlaude());

            Console.ReadLine();
        }
    }
}

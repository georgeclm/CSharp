using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace structure
{
    class Student
    {
        public string name,major;
        public double grade;
        public void printStudent()
        {
            Console.WriteLine("Student name: {0}", name);
            Console.WriteLine("Student major: {0}", major);
            Console.WriteLine("Student grade: {0}", grade);

        }

    }
}

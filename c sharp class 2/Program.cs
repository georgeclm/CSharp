using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_class_2
{
    class Program
    {
        static void Main(string[] args)
        {
            double pi = 3.14d;
            Console.Write("Enter number: ");
            int num = Convert.ToInt32 (Console.ReadLine());
            Console.WriteLine("Pi constant is " + pi);
            Console.WriteLine("And Your number is " + num);
            Console.ReadLine();
        }
    }
}

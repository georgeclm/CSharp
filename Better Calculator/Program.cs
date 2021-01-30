using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Better_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number : ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter a operator : ");
            string ope = Console.ReadLine();
            Console.Write("Enter a second number : ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            if (ope == "+")
            {
                Console.WriteLine(num1 + num2);
            } else if (ope == "-") {
                Console.WriteLine(num1 - num2);
            }
            else if (ope == "*")
            {
                Console.WriteLine(num1 * num2);
            }
            else if (ope == "/")
            {
                Console.WriteLine(num1 / num2);
            } else if (ope == "%")
            {
                Console.WriteLine(num1 % num2);
            }

            else
            {
                Console.WriteLine("Operator Invalid");
            }
            Console.ReadLine();
        }
    }
}

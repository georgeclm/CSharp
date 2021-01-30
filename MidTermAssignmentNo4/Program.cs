using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidTermAssignmentNo4
{
    class Program
    {
        static void Main(string[] args)
        {
            double i, result=1,number;
            Console.Write("Enter the number to factor : ");
            number = Convert.ToDouble(Console.ReadLine());
            for (i = 1; i <= number; i++)
            {
                result *= i;
            }
            Console.WriteLine("Factorial of {0} is {1}", number, result);
            Console.ReadLine();
        }
    }
}

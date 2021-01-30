using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidTermAssignmentNo2
{
    class Program
    {
        static void Main(string[] args)
        {
            double a,b,c;
            double d, x1, x2;
            Console.WriteLine("The format is ax^2+bx+c");
            Console.Write("Input the value of a: ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Input the value of b: ");
            b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Input the value of c: ");
            c = Convert.ToDouble(Console.ReadLine());
            d = (b * b) - (4 * a * c);
            if (d == 0)
            {
                x1 = -b / (2 * a);
                x2 = x1;
                Console.WriteLine("X1 root = " + x1);
                Console.WriteLine("X2 root = " + x2);
            }else if (d > 0)
            {
                x1 = (-b + Math.Sqrt(d)) / (2 * a);
                x2 = (-b - Math.Sqrt(d)) / (2 * a);
                Console.WriteLine("X1 root = " + x1);
                Console.WriteLine("X2 root = " + x2);
            }
            else
            {
                Console.WriteLine("Imaginary numbers");
                Console.WriteLine(a + (b * Math.Sqrt(-1)));//cant display the result because of imaginary numbers square root number.
            }
            Console.ReadLine();


        }
    }
}

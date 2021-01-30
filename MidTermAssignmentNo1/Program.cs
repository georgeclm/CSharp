using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidTermAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j, k, l, m, choice;
            double result;
            Console.WriteLine("Input 1 for area of triangle");
            Console.WriteLine("Input 2 for area of rectangle");
            Console.WriteLine("Input 3 for area of circle");
            Console.WriteLine("Input 4 to quit the program");
            trySwitch: Console.Write("Input your choice: ");
            choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
             {
                    case 1:
                        Console.Write("Input the base of the triangle: ");
                        i = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Input the height of the triangle: ");
                        j = Convert.ToInt32(Console.ReadLine());
                        result = 0.5 * i * j;
                        Console.WriteLine("The area of your triangle is " + result);
                        break;
                    case 2:
                        Console.Write("Input the length of the rectangle: ");
                        k = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Input the width of the rectangle: ");
                        l = Convert.ToInt32(Console.ReadLine());
                        result = k * l;
                        Console.WriteLine("The area of your rectangle is " + result);
                        break;
                    case 3:
                        Console.Write("Input the radius of the circle: ");
                        m = Convert.ToInt32(Console.ReadLine());
                        result = 3.14 * m * m;
                        Console.WriteLine("The area of your circle is " + result);
                        break;
                    case 4:
                        Environment.Exit(0);//exit 0 to exit the program without error or anything it quit all the program 
                        break;
                    default:
                        Console.WriteLine("Invalid selection");
                    goto trySwitch;
             }
             

            Console.ReadLine();
        }
    }
}

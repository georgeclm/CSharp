using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mad_libs
{
    class Program
    {
        static void Main(string[] args)
        {
            string color, noun, name;
            Console.Write("Enter a color:");
            color = Console.ReadLine();
            Console.Write("Enter a noun:");
            noun = Console.ReadLine();
            Console.Write("Enter a name:");
            name = Console.ReadLine();
            Console.WriteLine("Roses are " + color);
            Console.WriteLine( noun +" are white");
            Console.WriteLine("I love " + name);
            Console.ReadLine();

        }
    }
}

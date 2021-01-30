using System;

namespace calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the first number : ");
            double one = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the second number : ");
            double two = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(one + two);
            Console.ReadLine();
        }
    }
}

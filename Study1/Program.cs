using System;

namespace Study1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            

            Console.WriteLine("Enter two numbers.");
            Console.Write("Enter first number =");
            int one = int.Parse(Console.ReadLine());
            Console.Write("Enter second number =");
            int two = int.Parse(Console.ReadLine());
          
            /*Console.WriteLine("The Bigger Number is : " + Math.Max(one, two));
            Console.ReadLine();//orrr*/
            var output = (one > two) ? "The Bigger Number is " + one : "The bigger number is " + two;
            Console.WriteLine(output);
            Console.ReadLine();

        }
    }
}

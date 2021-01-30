using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int b = 1;
            int j = 1;
            int[] num = { 4, 8, 14, 632, 52, 32, 54, 243, 422, 454, 4, 432 };
            string[] friends;
            friends = new string[] { "John", "Dan", "George", "Budi" };
            Array.Sort(num);
            foreach (int i in num)
            {
                Console.WriteLine("{0} random number is: {1}",j,i);
                j++;
            }
            Console.WriteLine("The smallest number is: " + num.Min());
            Console.WriteLine("The biggest number is: " + num.Max());
            Console.WriteLine("Total all of the number is: " + num.Sum());
            foreach (string a in friends)
            {
                Console.WriteLine("My {0} friend is {1}", b,a);
                b++;
            }
            Console.ReadLine();
        }
    }
}

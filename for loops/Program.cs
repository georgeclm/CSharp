using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace for_loops

{
    class Program
    {
        static void Main(string[] args)
        {

            int[] num = { 54321,4321 , 321, 21, 1 };
            
            num[2] = 9999999;
            for (int a = 0; a < num.Length; a++)
            {
                Console.WriteLine(num[a]);
                Thread.Sleep(1000);
                //same exact program
            }
            Console.WriteLine("Countdown 10 Second \n Enter to start");
            Console.ReadLine();
            foreach (int element in num)
            {
                Console.WriteLine(element);
                Thread.Sleep(1000);

            }

            Console.ReadLine();

            
        }
    }
}

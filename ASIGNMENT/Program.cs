using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASIGNMENT
{
    class Program
    {
        static void Main(string[] args)
        {
            /*int input = new Random().Next(-5, 5);

            string classify;
            if (input >= 0)
            {
                classify = "positive";
            }
            else
            {
                classify = "negative";
            }
            
            */
            classify = (input >= 0) ? "  positive" : "  negative";
            Console.WriteLine(input + classify);
            /*
            int ten = 10;
            int i2 = 2147483647 + ten;
            Console.WriteLine(i2);
            Console.ReadLine();
          
         
            // int ten = 10;
            //Console.WriteLine(checked(2147483647 ;// + ten) ;
            //Console.ReadLine();*/
              
            

            

        }
    }
}

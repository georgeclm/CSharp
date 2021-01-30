using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_Handling
{
    class Program
    {
        private static string num1;

        static void Main(string[] args)
        {
            try
            {
                Console.Write("enter a number :  ");
                int num1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter a sec number : ");
                int num2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(num1 / num2);
               
                Console.Write("asdadasdddsd:");
                string test = Console.ReadLine().ToLower();//ToLower mean thing that you write will be in lowercase even if u use all uppercase
                Console.ReadLine();
            }
            catch(FormatException a)
            {
                Console.WriteLine("Are u kigfdsifnsnf??" + num1);
                Console.WriteLine(a.Message);

            }
            catch (DivideByZeroException b)
            {
                Console.WriteLine(b.Message);
            }
           
           
           
             finally
            {
                Console.WriteLine("U are troll");
            }
            Console.ReadLine();
        }
    }
}

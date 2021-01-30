using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace more_if_statements
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your first number: ");
            int no1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter your second number: ");
            int no2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter your third number: ");
            int no3 = Convert.ToInt32(Console.ReadLine());
           Console.WriteLine("Your biggest number is "+maxxx(no1, no2 , no3));
            Console.ReadLine();
          
        }
        static int maxxx(int num1, int num2, int num3)
        {
            //!= for not equal
            int result;
            if (num1>=num2 && num1>=num3)
            {
                result = num1;
            }
            else if (num2>=num1 && num2>=num3)
            {
                result = num2;
            }else
            {
                result = num3;
            }


            return result;
        }
    }
}

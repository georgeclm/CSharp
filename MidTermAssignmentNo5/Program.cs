using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidTermAssignmentNo5
{
    class Program
    {
        static void Main(string[] args)
        {/* i think it needs to use array to input the user data and we havent learned it yet so i dont know how to end the loops 
            when user input non integers because i dont really understand much about how arrays work 100% 
            if i write non integers into the input unexpected handling will happend */
            int limit = 0;
            Console.Write("Enter your maximum number to input: ");
            limit = Convert.ToInt32(Console.ReadLine());
         
               
                double[] array = new double[limit];
                Console.WriteLine("Please enter your number: ");
                for (int i = 0; i < limit; i++)
                {
                    array[i] = Convert.ToDouble(Console.ReadLine());
                }
                double sum = 0;
                foreach (double d in array)
                {
                    sum += d;
                }
                double avg = sum / limit;
                Console.WriteLine("The average of your numbers is {0} ", avg);
            
        
            Console.ReadLine();


        }
    }
}

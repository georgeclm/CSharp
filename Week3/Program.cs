using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Input today date number from 0-6 : ");
                int nummm = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(GetDate(nummm));

                
            }
            catch (FormatException a)
            {
                Console.WriteLine(a.Message);

            }
            Console.ReadLine();
        }
        static string GetDate(int dayNum)
        {
            string dayName;
            switch (dayNum)
            {
                case 0:
                    dayName = "Today is Sunday";
                    break;
                case 1:
                    dayName = "Today is Monday";
                    break;
                case 2:
                    dayName = "Today is Tuesday";
                    break;
                case 3:
                    dayName = "Today is Wednesday";
                    break;
                case 4:
                    dayName = "Today is Thursday";
                    break;
                case 5:
                    dayName = "Today is Friday";
                    break;
                case 6:
                    dayName = "Today is Saturday";
                    break;
                default:
                    dayName = "Invalid day number";
                    break;
            }



            return dayName;

        }
    }
}

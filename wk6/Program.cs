using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace wk6
{
    class Program
    {
        
        public static void Main(string[] args)
        {
            Console.Write("Input Your Day: ");
            string day = Console.ReadLine().ToLower();
            Console.WriteLine("Tomorrow is " + TomorrowDay(day));
            Console.Write("Input a number if the number is even then 'True' :");
            int z = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(IsEven(z));
            Console.WriteLine("Enter first coord: ");
            var t = Console.ReadLine();
            Console.WriteLine("Enter second coord: ");
            var g = Console.ReadLine();
           TrialMode(t,g);
            Console.ReadLine();
        }
        public static string TomorrowDay(string day)
        {
           string tomorrow;
            switch (day)
            {
                case "sunday":
                tomorrow = "Monday";
                break;
                case "monday":
                tomorrow = "Tuesday";
                break;
                case "tuesday":
                tomorrow = "Wednesday";
                break;
                case "wednesday":
                tomorrow = "Thursday";
                break;
                case "thursday":
                tomorrow = "Friday";
                break;
                case "friday":
                tomorrow = "Saturday";
                break;
                case "saturday":
                tomorrow = "Sunday";
                break;
                default:
                tomorrow = "Invalid Day Input";
                break;

            }


            return tomorrow;
           
        }
        public static bool IsEven(int input)
        {
            if (input % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
       public static void TrialMode(string u,string i)
        {
            string[] ulu = u.Split("");
            double a = Convert.ToDouble(ulu[0]);
            double b = Convert.ToDouble(ulu[1]);
            string[] uli = i.Split("");
            double c = Convert.ToDouble(uli[0]);
            double d = Convert.ToDouble(uli[1]);


            Console.WriteLine("The mid point is {0}, {1}",(a+ c)/2 + " , " + (b + d)/2);
        }
    }
}

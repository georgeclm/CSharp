using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace MidTermAssignmentNo3
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j, k, l, m, n,a=0,b=0,c;
            Console.WriteLine("Calculate duration of times of maximum 59 hours and the second set of input is always later than the first one");
            Console.Write("Imput first set hours: ");
            i = Convert.ToInt32(Console.ReadLine());
            Console.Write("Imput first set minute: ");
            j = Convert.ToInt32(Console.ReadLine());
            Console.Write("Imput first set second: ");
            k = Convert.ToInt32(Console.ReadLine());
            Console.Write("Imput second set hours: ");
            l = Convert.ToInt32(Console.ReadLine());
            Console.Write("Imput second set minute: ");
            m = Convert.ToInt32(Console.ReadLine());
            Console.Write("Imput second set second: ");
            n = Convert.ToInt32(Console.ReadLine());
            if (n <= 59 && k <= 59 && m <= 59 && j <= 59 && i <= 59 && n <= 59 && l >= i)
            {
                if (m != 0 || n>=k)
                {
                    if (n >= k && m >= j)
                    {
                        a = n - k;
                    }
                    else
                    {
                        a = (n + 60) - k;
                        m--;
                    }
                }
                else
                {
                    Console.Write("Negative time is not possible ");
                }

                if (l != 0 || m>=j)
                {
                    if (m >= j)
                    {
                        b = m - j;
                    }
                    else
                    {
                        b = (m + 60) - j;
                        l--;
                    }
                }
                else
                {
                    Console.Write("Negative time is not possible ");
                }
                if (l >= i)
                {
                    c = l - i;
                }
                else 
                {
                    c = 0;

                }
                    Console.WriteLine("The duration is {0}:{1}:{2}", c, b, a);
            }
            else
            {
                if (l < i)
                {
                   Console.WriteLine("Negative time is not possible");
                }
                else
                {
                    Console.WriteLine("Invalid time input");
                }
            }

            Console.ReadLine();
        }
    }
}

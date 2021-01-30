using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace Prog_assignment_timer_stopwatch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter to start the stopwatch");
            int a = Convert.ToInt32(Console.ReadLine());
            Timer timer = new Timer(1000);
            timer.Elapsed += Timer_Elapsed;
            timer.Start();
            Console.ReadKey();
            timer.Stop();
 
        }

        public static void Timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            for (int i=0;i < 10;i++) {
                Console.WriteLine(i);
            }
        }
    }
}

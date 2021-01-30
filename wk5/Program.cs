using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Diagnostics;

namespace wk5
{
    class Program
    {


        static void Main(string[] args)
        {

            string o;//variable for input minute and second
            Console.Write("Enter your time:");//ask for the minute
            o = Console.ReadLine();//input the minute value to the var
            Console.Write("Count Up or down (up or down): ");//ask for the timer count up or down
            string countValue = Console.ReadLine().ToLower();// input the answer value
            if (countValue == "up")// to chose what program to execute up /down/ or invalid input count from user
            {
                TimerCountUp.GetCountUp(o);//execute countup method in other class and input the minute and second value to the class
            }
            else if (countValue == "down")//if the countvalue is down then execute the countdown class
            {
                Timer_Countdown.GetTimer(o);//execute countdown method in other class and input the minute and second value to the class
            }
            else//if the user input isnt up and down then and invalid input
            {
                Console.WriteLine("Invalid count up or down value");// output for invalid countvalue input


            }
            Console.ReadLine();
            /*
             Assignment Prog Epafroditus George Clement Djaja Class 3 
            I think to stop or reset the timer also to display the count or not we need to use wform and we havent studied it yet Thank You Sir.
             */

        }

    }
}






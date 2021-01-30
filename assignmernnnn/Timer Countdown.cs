using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Diagnostics;

namespace wk5
{
    class Timer_Countdown//class for the timer countdown 
    {
        public static void GetTimer(string a)//create a method countdown and for input in the main source code and the name of class 
        {
            string[] words = a.Split(',');
            int j = Convert.ToInt32(words[0]);
            int z = Convert.ToInt32(words[1]);
            int i;//the variable for i 
            while (j >= 0 && j < 60 && z < 60)//while function to loop the timer until the minute goes minus and this loop wont run if input value is more than 59
            {
                for (i = z; i >= 0; i--)//for value inside while loop to loop second until 0 then reset
                {
                    Console.WriteLine(j + " : " + i);//output minute and second
                    Thread.Sleep(1000);//give 1 s  delay
                    z = 59;//after i value is 0 then this to loop back the second
                }
                j--;//after the second loop finished decrease minute value or j by 1 then repeat the for loop
            }

            if (j < 60 && z < 60)//if while function is done or not executed then check for invalid time input or the timer is finished.
            {
                Console.WriteLine("TIME IS UP");// if the input is correct then output this value

            }
            else
            {
                Console.WriteLine("Invalid Time Input");// if the input is false then output this value
            }
           
        }
    }
}

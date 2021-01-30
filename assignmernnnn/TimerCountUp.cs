using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace wk5
{
    class TimerCountUp // class for timer countup 
    {
        public static void GetCountUp(string a)//create a method for countup and for input in the main source code and the name of class
        {
            string[] words = a.Split(',');
            int j = Convert.ToInt32(words[0]);
            int z = Convert.ToInt32(words[1]);
            int i;//the variable for i 
            while (j <= 59  && z < 60)//while function to loop the timer until the minute goes is more than 59 and this loop wont run if input value is more than 59
            {
                for (i = z; i <= 59; i++)//for value inside while loop to loop second until 59 then reset its the opposite of timer countdown
                {
                    Console.WriteLine(j + " : " + i);//output minute and second
                    Thread.Sleep(1000);//give 1 s  delay
                    z = 0;//after i value is 59 then this to loop back the second
                }
                j++;//after the second loop finished increase minute value or j by 1 then repeat the  loop
            }

            if (j == 60)//if while function is done or not executed then check for invalid time input or the timer is finished.
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

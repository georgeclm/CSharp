using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Build_a_guessing_gamee
{
    class Program
    {
        static void Main(string[] args)
        {
            string pass = "george";            
            string guess = "";
            int guessCount = 0;
            int guessLimit = 5;
            bool outofGuesses = false;
            do
            {
                if (guessCount<guessLimit)
                {
                    Console.Write("Enter your password :");
                    guess = Console.ReadLine();
                    guessCount++;

                }
                else
                {
                    outofGuesses = true;
                }
                
            } while (guess != pass && !outofGuesses) ;
                if (outofGuesses)
            {
                Console.WriteLine("You are a hacker");
                
            }
            else
            {
                Console.Write("Welcome Back Sir" );
            }
            Console.ReadLine();
        }
    }
}

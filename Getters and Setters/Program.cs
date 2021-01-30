using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Getters_and_Setters
{
    class Program
    {
        static void Main(string[] args)
        {
            //rating only: G,PG,PG-13,R,NR if not then NR
            Movie avangers = new Movie("The Avangers","Tony Stark","Trol rating");
            avangers.printMovie();
            Movie shrek = new Movie("Shrek", "Adam", "PG");
            //cant change rating
            //shrek.rating = "Now trol rating too";
            shrek.printMovie();
            int numFruit;
            do
            {
                Console.Write("Enter the amount of fruit: ");
                try
                {
                    numFruit = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception)
                {
                    numFruit = 0;
                }
                finally
                {
                    Console.WriteLine("At least there is result");
                }
            } while (numFruit <= 0);
            Console.WriteLine(numFruit);
            Console.ReadLine();
        }
    }
}

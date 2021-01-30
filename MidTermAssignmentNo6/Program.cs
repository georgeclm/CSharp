using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidTermAssignmentNo6
{
    class Program
    {
        static void Main(string[] args)
        {/*I dont understand fully the question so i did what you ask based on my knowledge and this is the result because there are no detail about the condition
          or other requirment that need to be done so i make the basic one because there is no requirment or certain condition Thank You*/
            Console.Write("Input your file name and the extension (must include 1): ");
            var input = Console.ReadLine();
            Console.Write("Input how many new files(maximum 5): ");
            int fileCount = Convert.ToInt32(Console.ReadLine());

            if (fileCount == 1)
            {
                var new1 = input.Replace("1", "2");
                Console.WriteLine(new1);
            }else if (fileCount == 2)
            {
                var new1 = input.Replace("1", "2");
                Console.WriteLine(new1);
                var new2 = input.Replace("1", "3");
                Console.WriteLine(new2);
            }else if(fileCount == 3)
            {
                var new1 = input.Replace("1", "2");
                Console.WriteLine(new1);
                var new2 = input.Replace("1", "3");
                Console.WriteLine(new2);
                var new3 = input.Replace("1", "4");
                Console.WriteLine(new3);

            }else if (fileCount == 4)
            {
                var new1 = input.Replace("1", "2");
                Console.WriteLine(new1);
                var new2 = input.Replace("1", "3");
                Console.WriteLine(new2);
                var new3 = input.Replace("1", "4");
                Console.WriteLine(new3);
                var new4 = input.Replace("1", "5");
                Console.WriteLine(new4);
            }else if (fileCount == 5)
            {
                var new1 = input.Replace("1", "2");
                Console.WriteLine(new1);
                var new2 = input.Replace("1", "3");
                Console.WriteLine(new2);
                var new3 = input.Replace("1", "4");
                Console.WriteLine(new3);
                var new4 = input.Replace("1", "5");
                Console.WriteLine(new4);
                var new5 = input.Replace("1", "6");
                Console.WriteLine(new5);
            }
            else
            {
                Console.WriteLine("Invalid new files input");
            }
            Console.ReadLine();
                        
        }
    }
}

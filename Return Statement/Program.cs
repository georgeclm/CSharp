using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Return_Statement
{
    class Program
    {
        static void Main(string[] args)
        {
            int cubednumber = cube(9);
            Console.WriteLine( cubednumber);
            Console.ReadLine();
        }
        static int cube(int num)
        {
            int result = num * num * num;
            return result;
        }
    }
}

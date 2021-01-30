using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace While_statements
    
{
    using System.Threading;
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            while (a >= 0) 
            {
                Console.WriteLine(a);
                Thread.Sleep(1000); 
                a--;
                
            } 

                Console.ReadLine();
        }
    }
}

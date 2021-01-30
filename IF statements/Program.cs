using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace IF_statements
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isMale = true;
            //bool isTall = true;
            // use && for both true use || for one of the condition 
            /* if (isMale && isTall)
             {
                 Console.WriteLine("You are a tall male");
             }else if(isMale && !isTall){
                 Console.WriteLine("You are a short male"); 
             }else if (!isMale && isTall)
             {
                 Console.WriteLine("You are a tall female");
             }
             else
             {
                 Console.WriteLine("You are a short female");
             }*/
            var output = (isMale) ? "You are a \n male" : "You are not a male";
            Console.WriteLine(output);
            Console.ReadLine();
        }
    }
}

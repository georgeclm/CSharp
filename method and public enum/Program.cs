using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace method
{
    public enum Days
    {
        Monday=1, Tuesday=2,Wednesday=3,Thursday=4, Friday=5, Saturday=6,  Sunday=7,
    };
    class Program
    {

        static void Main(string[] args)
        {

            Console.WriteLine((Days)1);
            SayHi("John",41,186);
            SayHi("Johnny",12,124);
            SayHi("Johnnnnay",45,156);
            Console.ReadLine();
        }
        static void SayHi(string name, int age, int height)
        {
            Console.WriteLine("Hello " + name +" you are " + age+ " and you are "+ height +"cm");
        }
    }
}

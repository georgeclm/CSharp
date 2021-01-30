using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Chef chef = new Chef();
            chef.MakeSpecialDish();
            Italianchef   chef2= new Italianchef();
            chef2.MakeSpecialDish();
            Console.ReadLine();
        }
    }
}

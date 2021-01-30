using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance
{
    class Italianchef : Chef// thi is inheretance system check it out
    {
        public override void MakeSpecialDish()
        {
            Console.WriteLine("The Chef makes bbq chicken");
        }
        public void MakePasta()
        {
            Console.WriteLine("The chef makes pasta");
        }

    }
}

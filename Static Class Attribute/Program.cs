using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static_Class_Attribute
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Song count is {0}",Song.songCount);
            Song music1 = new Song("Holiday","Green Day",342);
            music1.artist = "Jonny";
            music1.printSong();
            Song music2 = new Song("Kashmr", "Led Zepellin", 253);
            music2.printSong();
            Console.ReadLine();
        }
    }
}

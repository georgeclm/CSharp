using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Static_Class_Attribute
{
    class Song
    {
        public string title,artist;
        public int duration;
        public static int songCount = 0;
        public Song(string aTitle, string anArtist, int aDuration)
        {
            this.title = aTitle;
            this.artist = anArtist;
            this.duration = aDuration;
            songCount++;
        }
        public int getSongCount()
        {
            return songCount;
        }
        public void printSong()
        {
            Console.WriteLine("The {0} song title is {1}, the artist is {2} and the duration of the song is {3} second.", Song.songCount,title,artist,duration);

        }

    }
}

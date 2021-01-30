using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalExam
{
    // for the movie class
    class Movie
    {
        // movie variable private for rating
        // private so inside the code it still cant be changed only by input 
        public string title;
        public string main_character;
        private string rating;
        public static int movieCount = 0;
        // for the constructors
        public Movie(string aTtile,string aMainCharater, string aRating)
        {
            this.title = aTtile;
            this.main_character = aMainCharater;
            this.Rating = aRating;
            movieCount++;
        }
        public string Rating
        {
            // for the rating funtion with excpetion value using Rating with capital R so every value that got in will get through this getters and setters function to set the real rating 
            get { return rating; }
            set 
            { 
                if(value == "G" || value == "PG-13" || value == "R" || value == "NC-17" || value == "PG" || value == "NR")
                {
                    // take the real rating
                    rating = value;
                }
                else
                {
                    rating = "NR";
                }

            }
        }
        // the print movie function
        public void printMovie()
        {
            Console.WriteLine("The {0} Movie title is {1}, the main character of the movie is {2} and the rating of the movie is {3}.Stored", Movie.movieCount, title, main_character, rating);
        }
    }
}

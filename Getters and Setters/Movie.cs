using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Getters_and_Setters
{
    class Movie
    {
        public string title;
        public string Main_Character;
        private string rating;
        public static int movieCount = 0;
        public Movie(string aTitle, string aMainCharacter, string aRating)
        {
            this.title = aTitle;
            this.Main_Character = aMainCharacter;
            this.Rating = aRating;
            movieCount++;

        }
        public string Rating
        {
            get 
            { 
                return rating; 
            }
            set { 
                if(value == "G" || value == "PG-13" || value =="R" || value == "NR" || value == "PG")
                {
                    rating = value;
                }
                else
                {
                    rating = "NR";
                }
            }
        }
        public void printMovie()
        {
            Console.WriteLine("The {0} movie title is {1}, the main character is {2} and the rating  is {3}.",Movie.movieCount, title, Main_Character, rating);

        }

    }
}


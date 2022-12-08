using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevBuildBlockBuster
{
    public class BlockBuster
    {
        List<Movie>Movies { get; set; }
        public BlockBuster( List<Movie> movies)
        { 
            Movies = movies;
        }

        //public override void Play()
        //{
            
        //}

        public void PrintMovies()
        {
            int count = 1; 
            //Will print all of the movie titles in the movie list with their indexes 
           foreach(var movie in Movies)
            {
                Console.WriteLine($"{count++}) {movie.Title}");
            }

          
        }

       public Movie CheckOut()
        {
            PrintMovies();

            //User provides a number to reference he movie 
            Console.Write("Please select a movie you want to watch: ");
            int userSelection = int.Parse(Console.ReadLine());

         foreach(Movie movie in Movies)
            {
                movie.PrintScenes();
            }
            //Print the details of the movie they selected 
            if (userSelection == 1)
            {
                
            }
            else if (userSelection == 2)
            {
                second.PrintInfo();
            }
            else if (userSelection == 3)
            {
                third.PrintInfo();
            }
            else if (userSelection == 4)
            {
                fourth.PrintInfo();
            }
            else if (userSelection == 5)
            {
                fifth.PrintInfo();
            }
            else if (userSelection == 6)
            {
                sixth.PrintInfo();
            }
        }
            //ask the user which move they want to check out
            // get the index from the user
            // select the movie from the list 
            // Prints the "PrintInfo()" method from Movie class
            // Return the movie object selected by the user
        
    }
}

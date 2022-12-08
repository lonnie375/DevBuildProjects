using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevBuildBlockBuster
{
    public abstract class Movie
    {
        public string Title { get; set; }
        public Genre Category { get; set; }
        public int RunTime { get; set; }    
        List<string> Scenes { get; set; }

        //Added constructor by myself 

        public Movie(string title, Genre category, int runTime, string scenes)
        {
            Title = title;
            Category = category;
            RunTime = runTime;
            Scenes = new List<string>(); 
            Scenes.Add(scenes);
        }

        public virtual void PrintInfo()
        {
            //Prints all properties in the class to the console 
            Console.WriteLine($"Movie title:{Title}, Category:{Category}, Run Time:{RunTime}, Scenes Available:{string.Join(" ", Scenes)}");
        }

        public virtual void PrintScenes()
        {
            //prints all scenes in he list along with their index**
            for(int i = 1; i < Scenes.Count; i++)
            {
                Console.WriteLine($"{i} {Scenes[i]}");   
            }
        }

        public abstract void Play();
    }



    public enum Genre
    {
        drama, 
        comedy, 
        horror, 
        romance, 
        action
    }
}

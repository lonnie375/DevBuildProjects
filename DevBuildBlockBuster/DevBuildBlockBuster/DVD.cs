using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevBuildBlockBuster
{
    public class DVD : Movie
    {
        public DVD(string title, Genre category, int runTime, string scenes) : base(title, category, runTime, scenes)
        {
          
        }

        public override void Play()
        {
            //Ask the user what scene they want to watch 
            Console.Write("Would scene would you like to watch? ");
            string sceneSelect = Console.ReadLine().ToLower();

            //print all available scenes
            PrintScenes();

            //Allow the user to select a scene from the list and print it out**

        }
    }
}

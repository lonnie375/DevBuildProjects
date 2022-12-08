using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevBuildBlockBuster
{
    public class VHS : Movie
    {
        public int CurrentScene { get; set; } //verify the data type 
        public VHS(int currentScene, string title, Genre category, int runTime, string scenes) : base(title, category, runTime, scenes)
        {
           CurrentScene = currentScene;
        }

      

        public override void Play()
        {
            //plays the scene at "currentScene"**

            Console.WriteLine(CurrentScene);
            //increments CurrentScene
            CurrentScene++; 
        }

        public void Rewind()
        {
            CurrentScene = 0;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyVersionOfDevBuildRockPaperScissors
{
    public class RandomPlayer : Player
    {
        public RandomPlayer(string name) : base(name)
        {
            Name = name;
        }

        public override void Generate()
        {
            //Generates random 
            Random random = new Random();
            CurrentChoice = (Roshambo)random.Next(3);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevBuildRockPaperScissors
{
    public class RandomPlayer : Player 
    {

        public RandomPlayer(string name) : base(name)
        {
            Name = name; 
        }

        public override void Generate()
        {
            //Should generate a random Rashambo 
            Random rnd = new Random();
            CurrentChoice = (Roshambo)rnd.Next(0, 3);
        }
    }
}

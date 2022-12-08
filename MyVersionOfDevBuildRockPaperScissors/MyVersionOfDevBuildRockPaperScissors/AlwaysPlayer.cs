using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyVersionOfDevBuildRockPaperScissors
{
    public class AlwaysPlayer : Player
    {
        public AlwaysPlayer(string name, Roshambo play) : base(name)
        {
            Name = name; 
            CurrentChoice = play;

        }
    }
}

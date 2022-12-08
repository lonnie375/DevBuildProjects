using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyVersionOfDevBuildRockPaperScissors
{
    public abstract class Player
    {
        public string Name { get; set; }    
        public Roshambo CurrentChoice { get; set; }

        public Player(string name)
        {
            Name = name;
        }

        public virtual void Generate()
        {

        }
    }
}

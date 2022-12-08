using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevBuildRockPaperScissors
{
    
    public abstract class Player
    {
        public string Name { get; set; }    
        public Roshambo CurrentChoice { get; set; }


        //He removed the constructor out of the lab so you can remove this 
        public Player(string name)
        {
            Name = name;
            
        }
        //We no longer have to make this class Abstract 
        public virtual void Generate()
        {

        }
    }
}

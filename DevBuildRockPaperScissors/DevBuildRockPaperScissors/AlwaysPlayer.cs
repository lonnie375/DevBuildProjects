using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevBuildRockPaperScissors
{
    public class AlwaysPlayer : Player
    {
        private Roshambo always { get; set; }

        public AlwaysPlayer(string name, Roshambo player) : base (name)
        {
            Name = name;
            CurrentChoice = player;
           
        }

        //We don't need a Generate because it will always be the same. 
        //public override void Generate()
        //{
        //    throw new NotImplementedException();
        //}
    }
}

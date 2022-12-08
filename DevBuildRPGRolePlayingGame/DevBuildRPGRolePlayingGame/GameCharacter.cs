using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevBuildRPGRolePlayingGame
{
    public class GameCharacter
    {
        public string name { get; set; }
        public int strength { get; set; }
        public int intelligence { get; set; }

        public GameCharacter(string name, int strength, int intelligence)
        {
            this.name = name;
            this.strength = strength;
            this.intelligence = intelligence;
        }   

        public virtual void Play()
        {
            Console.WriteLine($"{name} has a strength level of {strength} and their intelligence is {intelligence}");
        }
    }
}

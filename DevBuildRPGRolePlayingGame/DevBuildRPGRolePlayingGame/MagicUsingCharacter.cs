using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevBuildRPGRolePlayingGame
{
    public class MagicUsingCharacter : GameCharacter
    {
        public int magicalEnergy { get; set; }

        public MagicUsingCharacter(string name, int strength, int intelligence,int magicalEnergy) : base(name, strength, intelligence)
        {
            this.magicalEnergy = magicalEnergy;
        }

        public override void Play()
        {
            Console.WriteLine($"{name} has a strength level of {strength} and their intelligence is {intelligence}. {name} magicalEnergy level is {magicalEnergy}");
        }
    }
}

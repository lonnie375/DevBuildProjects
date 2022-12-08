using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevBuildRPGRolePlayingGame
{
    public class Wizard : MagicUsingCharacter
    {
        public int spellNumber { get; set; }

        public Wizard(int spellNumber, string name, int strength, int intelligence, int magicalEnergy) : base(name, strength, intelligence, magicalEnergy)
        {
            this.spellNumber = spellNumber;
        }

        public override void Play()
        {
            Console.WriteLine($"{name} has a strength level of {strength} and their intelligence is {intelligence}. {name} spell number is {spellNumber} with a magical Energy of {magicalEnergy}");
        }
    }
}

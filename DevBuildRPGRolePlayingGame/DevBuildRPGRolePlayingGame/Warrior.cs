using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevBuildRPGRolePlayingGame
{
    public class Warrior : GameCharacter
    {
        public string weaponType { get; set; }

        public Warrior(string name, int strength, int intelligence, string weaponType) : base(name, strength, intelligence)
        {
            this.weaponType = weaponType;
        }
        public override void Play()
        {
            Console.WriteLine($"{name} has a strength level of {strength} and their intelligence is {intelligence}. {name} weaponType is {weaponType}");
        }
    }
}

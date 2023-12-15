using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParprogrammeringPokemon
{
    internal class Pokemon
    {
        string Name { get; set; }
        public int attack { get; set; }
        public int hp { get; set; }

        public Pokemon(string name,  int attack, int hp)
        {
            Name = name;
            this.attack = attack;
            this.hp = hp;
        }

        public void Attack (Pokemon target)
        {
            Console.WriteLine($"{Name} used Tackle! for {attack} damage");
            target.hp -= attack;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParprogrammeringPokemon
{
    internal class HealthPot : Items  
    {
        public int HealingAmount;
        public HealthPot(int healing)
        {
            HealingAmount = healing;
        }

        public void Use(Pokemon pokemon)
        {
            pokemon.hp += HealingAmount;
        }
    }
}

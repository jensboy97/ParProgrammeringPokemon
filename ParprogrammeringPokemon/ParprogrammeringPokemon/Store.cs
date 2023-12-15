using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParprogrammeringPokemon
{
    internal class Store
    {
        private List<HealthPot> items = new List<HealthPot>;
        public void GoToStore()
        {
            Console.WriteLine("Welcome to store\n" +
                              "1. Health potion\n" +
                              "2. Pokeball\n" +
                              "3. leave shop");
            int choose = Convert.toUInt32(Console.Readkey);
            switch (choose)
            {
                case 1: 
                    Items.Remove(Inventory.HealthPot)
                    break;
                case 2:
                    Items.Remove(Inventory.Pokeball)
            }
        }

        public void Sell(Trainer sellTo, Item item)
        {
            sellTo.Inventory.Add(item);
            items.Remove(item);
        }
    }
}

namespace ParprogrammeringPokemon
{
    internal class Trainer
    {
        public string Name { get; set; }
        public List<Pokemon> pokemons = new List<Pokemon>();
        public List<Items> Inventory = new List<Items>();

        public Trainer(string name, Pokemon startingPokemon)
        {
            Name = name;
            pokemons = new List<Pokemon> { startingPokemon };
        }

        internal void WalkAround()
        {
            Console.WriteLine("You walk around");
        }

        internal void CheckYourPokemon()
        {
            foreach (var pokemon in pokemons)
            {
                Console.WriteLine($"{Name}");
            }
        }

    }
}

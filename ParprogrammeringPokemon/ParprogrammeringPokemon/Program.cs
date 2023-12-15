namespace ParprogrammeringPokemon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Init();
            //var pikachu = new Pokemon("Pikachu", 10, 50);
            //var ash = new Trainer("Ash", pikachu);
        }

        private static void Init()
        {
            var player = StartUp();
            Menu(player);
        }
        private static Trainer StartUp()
        {
            Console.Clear();
            Console.WriteLine("Welcome to PokeMeSilly");
            Console.WriteLine("----------------------");
            Console.Write("Please enter your name: ");
            var name = Console.ReadLine();
            Console.WriteLine("What would you like to name your first Pokémon?");
            var pokeName = Console.ReadLine();
            var pokemon = new Pokemon(pokeName, 10, 50);
            return new Trainer(name, pokemon);
        }

        private static void Menu(Trainer trainer)
        {
            Console.Clear();
            Console.WriteLine("What would you like to do next?");
            Console.WriteLine("1. Go to store");
            Console.WriteLine("2. Explore");
            Console.WriteLine("3. Your Pokemon list");
            Console.WriteLine("4. Restart game");
            string? option = Console.ReadLine();
            switch (option)
            {
                case "1":
                    //GoToStore();
                    break;
                case "2":
                    //Explore();
                    break;
                case "3":
                    trainer.CheckYourPokemon();
                    break;
                case "4":
                    Init();
                    break;
                default:
                    Console.WriteLine("Invalid option plz choose between 1 to 4");
                    Thread.Sleep(2000);

                    Menu(trainer);
                    break;
            }
        }
    }

}
/*
 * Pokemon
   Appen du skal lage må ha en pokemontrener. 
   Brukeren skal få velge navn og startpokemon.
   Treneren skal ha mulighet til å gå i forskjellig terreng (grass, vann) der vilkårlige pokemen kan dukke opp.
   Man kan fange eller kjempe mot de ville pokemenna som dukker opp (det kan hende de også stikker av). 
   Treneren kan også gå inn i pokeshop for å skaffe seg flere pokeballer eller health potions som kan brukes i combat.
   Man skal ha mulighet til å se hvilke pokemen treneren har, og også annen inventory som pokeballer/potions.
*/
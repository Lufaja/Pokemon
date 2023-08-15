namespace Simulator;
using System;
using System.Security.Cryptography.X509Certificates;
internal class Program
{
    static void Main(string[] args)
    {
        List<Pokeball> team = new List<Pokeball> { };

        Console.WriteLine("Enter your trainer's name: ");
        string Trainer_1 = Console.ReadLine();

        Console.WriteLine("Enter second trainer's name: ");
        string Trainer_2 = Console.ReadLine();
        Trainer trainer1 = new Trainer(Trainer_1);
        Trainer trainer2 = new Trainer(Trainer_2);
        bool x = true;
        for (int i = 0; i <= 1; i++)
        {
            Pokemon charmander = new Charmander("charmander", true);
            Pokemon bulbasaur = new Bulbasaur("bulbasaur", true);
            Pokemon squirtle = new Squirtle("squirtle", true);
            Pokeball pokeball1 = new Pokeball(false, charmander);
            trainer1.AddPokemon(pokeball1);
            Pokeball pokeball2 = new Pokeball(false, bulbasaur);
            trainer1.AddPokemon(pokeball2);
            Pokeball pokeball3 = new Pokeball(false, squirtle);
            trainer1.AddPokemon(pokeball3);
        }
        for (int i = 0; i <= 1; i++)
        {
            Pokemon charmander = new Charmander("charmander", true);
            Pokemon bulbasaur = new Bulbasaur("bulbasaur", true);
            Pokemon squirtle = new Squirtle("squirtle", true);
            Pokeball pokeball1 = new Pokeball(false, charmander);
            trainer2.AddPokemon(pokeball1);
            Pokeball pokeball2 = new Pokeball(false, bulbasaur);
            trainer2.AddPokemon(pokeball2);
            Pokeball pokeball3 = new Pokeball(false, squirtle);
            trainer2.AddPokemon(pokeball3);

        }
        Battle battle = new Battle(trainer1, trainer2);
        Arena arena = new Arena(battle);
        arena.ArenaBattle();
        
    }

}

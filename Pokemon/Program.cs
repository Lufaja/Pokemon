using Pokemon;
using System;
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
        for (int i = 0; i <= 5; i++)
        {
            Charmander charmander = new Charmander("charmander", "fire", "water", 100);
            Pokeball pokeball = new Pokeball(false, charmander);
            trainer1.AddPokemon(pokeball);

        }
        for (int i = 0; i <= 5; i++)
        {
            Charmander charmander = new Charmander("charmander", "fire", "water", 100);
            Pokeball pokeball = new Pokeball(false, charmander);
            trainer2.AddPokemon(pokeball);
        }
        while (x)
        {
            for (int i = 1; i <= 6; i++)
            {
                trainer1.Throw(i);
                trainer1.CallBack();
                trainer2.Throw(i);
                trainer2.CallBack();
            }
            Console.WriteLine("Do you want to continue y/n: ");
            string check_state = Console.ReadLine().ToLower();
            if (check_state == "y")
            {
                x = true;
            }
            else
            {
                x = false; break;
            }
        }
    }

}
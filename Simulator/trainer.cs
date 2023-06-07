using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Simulator
{
    internal class Trainer
    {
        public Pokemon CurrentPkmn;
        public string name;
        public List<Pokeball> belt = new List<Pokeball>();
        public Trainer(string name)
        {
            this.name = name;
        }
        public void setName(string NewName)
        {
            name = NewName;
        }
        public string getName()
        {
            return name;
        }

        public Pokemon Throw(int PokemonIndex)
        {
            if (CheckField())
            {
                //Console.WriteLine("Which pokemon do you want to send out? (1/6): ");
                //int PokemonIndex = Int32.Parse(Console.ReadLine());
                var pokeball = this.belt[PokemonIndex - 1];
                Console.WriteLine($"{this.name} sent out {pokeball.charmander.getName()}!");
                pokeball.charmander.BattleCry();
                this.CurrentPkmn = pokeball.OpenBall();
                return this.belt[PokemonIndex - 1].OpenBall();
            }
            else { return this.CurrentPkmn; }
        }
        public void CallBack()
        {
            Console.WriteLine("Come back " + this.CurrentPkmn.getName() + "!");
            foreach (var pokeball in this.belt)
            {
                if (pokeball.GetState())
                {
                    pokeball.CloseBall(CurrentPkmn);
                }
            }
            this.CurrentPkmn = null;
        }
        public void AddPokemon(Pokeball pokeball)
        {
            if (belt.Count >= 6)
            {
                Console.WriteLine("It failed! Your team already has 6 pokemon!");
            }
            else
            {
                this.belt.Add(pokeball);
                Console.WriteLine($"{pokeball.charmander.getName()} has been added to your team");
            }
        }
        public void ShowTeam()
        {
            Console.WriteLine($"{this.name}'s Team ");
            int index = 1;
            foreach (var pokemon in belt)
            {
                Console.WriteLine(index + ". " + pokemon.charmander.getName());
                index++;
            }
        }
        public bool CheckField()
        {
            if (CurrentPkmn == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}

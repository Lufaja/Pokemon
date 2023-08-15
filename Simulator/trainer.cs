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

        public void reviveAll()
        {
            foreach (Pokeball pokeball in belt)
            {
                pokeball.pokemon.setAlive(true);
            }
        }

        public Pokemon Throw(Pokeball pokeball)
        {
            Console.WriteLine($"{this.name} sent out {pokeball.pokemon.getName()}!");
            pokeball.pokemon.BattleCry();
            return pokeball.OpenBall();
        }
        public void CallBack(Pokemon CurrentPkmn)
        {
            Console.WriteLine("Come back " + CurrentPkmn.getName() + "!");
            foreach (var pokeball in this.belt)
            {
                if (pokeball.GetState())
                {
                    pokeball.CloseBall(CurrentPkmn);
                }
            }
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
                Console.WriteLine($"{pokeball.pokemon.getName()} has been added to your team");
            }
        }
        public void ShowTeam()
        {
            Console.WriteLine($"{this.name}'s Team ");
            int index = 1;
            foreach (var pokemon in belt)
            {
                Console.WriteLine(index + ". " + pokemon.pokemon.getName());
                index++;
            }
        }
        public bool CheckField(Pokemon CurrentPkmn)
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
        public Pokeball pickRandomPokeball()
        {
            if (!checkBelt())
            {
                return null;
            }
            List<Pokeball> pokeballsAvailable = new List<Pokeball>();
            foreach (Pokeball pokeball in belt)
            {
                if (pokeball.getAlive())
                {
                    pokeballsAvailable.Add(pokeball);
                }
            }
            Random rnd = new Random();
            int num = rnd.Next(0, pokeballsAvailable.Count);
            Pokeball randomPokeball = pokeballsAvailable[num];
            return randomPokeball;
        }

        public bool checkBelt()
        {
            int pokemonAvailable = 0;
            foreach (Pokeball pokeball in belt)
            {
                if (pokeball.getAlive())
                {
                    pokemonAvailable += 1;
                }
            }
            if (pokemonAvailable > 0)
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

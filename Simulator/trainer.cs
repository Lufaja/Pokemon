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
        private string name;
        private List<Pokeball> belt = new List<Pokeball>();
        private int maxPokemon = 6;

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
                var x = pokeball.getPokemon();
                x.setAlive(true);
                pokeball.setPokemon(x);
            }
        }

        public Pokemon Throw(Pokeball pokeball)
        {
            Console.WriteLine($"{this.name} sent out {pokeball.getPokemon().getName()}!");
            pokeball.getPokemon().BattleCry();
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
            if (belt.Count >= maxPokemon)
            {
                throw new Exception($"It failed! Your team already has {maxPokemon} pokemon!");
            }
            else
            {
                this.belt.Add(pokeball);
                Console.WriteLine($"{pokeball.getPokemon().getName()} has been added to your team");
            }
        }
        public void ShowTeam()
        {
            Console.WriteLine($"{this.name}'s Team ");
            int index = 1;
            foreach (var pokeball in belt)
            {
                Console.WriteLine(index + ". " + pokeball.getPokemon().getName());
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

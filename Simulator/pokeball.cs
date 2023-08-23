using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Simulator
{
    internal sealed class Pokeball
    {
        private Pokemon pokemon;
        private bool state;

        public Pokeball(bool state, Pokemon pokemon)
        {
            this.state = state;
            this.pokemon = pokemon;
        }
        public void ThrowPokeball()
        {
            Console.WriteLine(this.pokemon);
        }
        public Pokemon getPokemon()
        {
            return pokemon;
        }
        public void setPokemon(Pokemon pokemon)
        {
            this.pokemon = pokemon;
        }
        public bool getState()
        {
            return state;
        }
        public bool getAlive()
        {
            return pokemon.getAlive();
        }

        public void setAlive(bool alive)
        {
            pokemon.setAlive(alive);
        }
        public Pokemon OpenBall()
        {
            var pokemon = this.pokemon;
            this.state = true;
            return pokemon;
        }
        public void CloseBall(Pokemon pokemon)
        {
            this.pokemon = pokemon;
            this.state = false;
        }



    }

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Simulator
{
    internal class Pokeball
    {
        public Pokemon pokemon;
        public bool state;

        public Pokeball(bool state, Pokemon pokemon)
        {
            this.state = state;
            this.pokemon = pokemon;
        }
        public void ThrowPokeball()
        {
            Console.WriteLine(this.pokemon);
        }
        public bool GetState()
        {
            return this.state;
        }
        public bool getAlive()
        {
            return pokemon.getAlive();
        }

        public void setAlive(bool alive)
        {
            this.pokemon.setAlive(alive);
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

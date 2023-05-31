using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon
{
    class Pokeball
    {
        public Charmander charmander;
        public bool state;

        public Pokeball(bool state, Charmander charmander)
        {
            this.state = state;
            this.charmander = charmander;
        }
        public void ThrowPokeball()
        {
            Console.WriteLine(this.charmander);
        }
        public bool GetState()
        {

            return this.state;

        }
        public int getHp()
        {
            return this.charmander.getHp();
        }
        public Charmander OpenBall()
        {
            var pokemon = this.charmander;
            this.charmander = null;
            this.state = true;
            return pokemon;
        }
        public void CloseBall(Charmander charmander)
        {
            this.charmander = charmander;
            this.state = false;
        }



    }

}
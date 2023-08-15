using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulator
{
    internal class Charmander : Pokemon
    {
        public Charmander(string name, bool alive) : base(name, alive)
        {
            this.species = "Charmander";
            this.type = "Fire";
            this.weakness = "Water";
        }
        public override void BattleCry()
        {
            Console.WriteLine(this.species);
        }
    }


}

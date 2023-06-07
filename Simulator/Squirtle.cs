using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Simulator
{
    internal class Squirtle : Pokemon
    {
        public Squirtle(string name, int hp) : base(name, hp)
        {
            this.species = "Squirtle";
            this.type = "Water";
            this.weakness = "Grass";
        }
        public override void BattleCry()
        {
            Console.WriteLine(this.species);
        }
    }
}

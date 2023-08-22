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
        public Squirtle(string name, bool alive) : base(name, alive)
        {
            setSpecies("Squirtle");
            setType(AttributeTypes.Water);
            setWeakness(AttributeTypes.Grass);
        }
        public override void BattleCry()
        {
            Console.WriteLine(getSpecies());
        }
    }

}

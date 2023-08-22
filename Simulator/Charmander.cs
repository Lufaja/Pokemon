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
            setSpecies("Charmander");
            setType(AttributeTypes.Fire);
            setWeakness(AttributeTypes.Water);
        }
        public override void BattleCry()
        {
            Console.WriteLine(getSpecies());
        }
    }


}

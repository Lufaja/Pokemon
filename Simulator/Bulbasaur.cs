using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulator
{
    internal class Bulbasaur : Pokemon
    {
        public Bulbasaur(string name, bool alive) : base(name, alive)
        {
            setSpecies("Bulbasaur");
            setType(AttributeTypes.Grass);
            setWeakness(AttributeTypes.Fire);
        }
        public override void BattleCry()
        {
            Console.WriteLine(getSpecies());
        }
    }

}

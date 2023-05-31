using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon
{
    using System;



    class Charmander
    {
        public string name;
        public string species = "Charmander";
        public string type;
        public string weakness;
        public int hp;

        public Charmander(string name, string type, string weakness, int hp)
        {
            this.name = name;
            this.type = type;
            this.weakness = weakness;
            this.hp = hp;
        }
        public string getName()
        {
            return name;
        }
        public string getType()
        {
            return type;
        }
        public string getWeakness()
        { return weakness; }

        public int getHp()
        { return hp; }

        public void setHp(int hp)
        {
            this.hp = hp;
        }

        public void setName(string name)
        {
            this.name = name;
        }
        public void BattleCry()
        {
            Console.WriteLine(this.species);
        }
    }
}
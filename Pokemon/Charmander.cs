using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon
{
    public class Charmander
    {
        public string name;
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
        public string GetName()
        {
            return name;
        }
        public void SetName(string name)
        {
            this.name = name;
        }
        public string GetType()
        {
            return type;
        }
        public string GetWeakness()
        { return weakness; }

        public int GetHp()
        { return hp; }

        public void BattleCry()
        {
            for (int i = 0; i <= 10; i++)
            { Console.WriteLine(this.name); }
        }
    }
}

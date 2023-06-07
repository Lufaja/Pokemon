using System;
internal abstract class Pokemon
{
    public string name;
    public string species;
    public string type;
    public string weakness;
    public int hp;

    public Pokemon(string name, int hp)
    {
        this.name = name;
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
    public abstract void BattleCry();
}

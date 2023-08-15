using System;
internal abstract class Pokemon
{
    public string name;
    public string species;
    public string type;
    public string weakness;
    public bool alive;

    public Pokemon(string name, bool alive)
    {
        this.name = name;
        this.alive = alive;
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

    public bool getAlive()
    { return alive; }

    public void setAlive(bool alive)
    {
        this.alive = alive;
    }
    public void setName(string name)
    {
        this.name = name;
    }
    public string getStrength()
    {
        return type;
    }
    public abstract void BattleCry();
}
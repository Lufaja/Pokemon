using Simulator;
using System;
internal abstract class Pokemon
{
    private string species;
    private string name;
    private AttributeTypes type;
    private AttributeTypes weakness;
    private bool alive;

    public Pokemon(string name, bool alive)
    {
        this.name = name;
        this.alive = alive;
        this.type = new AttributeTypes();
        this.weakness = new AttributeTypes();
    }

    public string getSpecies()
    {
        return species;
    }
    public void setSpecies(string species)
    {
        this.species = species;
    }
    public string getName()
    {
        return name;
    }
    public AttributeTypes getType()
    {
        return type;
    }
    public void setType(AttributeTypes type)
    {
        this.type = type;
    }
    public AttributeTypes getWeakness()
    { return weakness;}
    public void setWeakness(AttributeTypes weakness)
    {
        this.weakness = weakness;
    }
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
    public AttributeTypes getStrength()
    {
        return type;
    }
    public abstract void BattleCry();
}
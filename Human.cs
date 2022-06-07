public class Human
{
    // properties
    public string Name;
    public int Strength;
    public int Intelligence;
    public int Dexterity;
    public int Health;

    // constructor with default values besides name
    public Human(string name)
    {
        Name = name;
        Strength = 3;
        Intelligence = 3;
        Dexterity = 3;
        Health = 100;
    }
    
    // constructor that can assign custom values to all fields
    public Human(string name, int str, int intel, int dex, int health)
    {
        Name = name;
        Strength = str;
        Intelligence = intel;
        Dexterity = dex;
        Health = health;
    }

    // Attack method
    public virtual int Attack(Human target)
    {
        target.Health = target.Health - (5 * this.Strength);
        return target.Health;
    }


}
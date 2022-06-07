public class Wizard : Human
{
    public Wizard(string name) : base (name)
    {
        Intelligence = 25;
        Health = 50;
    }
    public override int Attack(Human target)
    {
        target.Health = target.Health - (5 * this.Intelligence);
        this.Health = this.Health + (5 * this.Intelligence);
        return target.Health;
    }
    
    public int Heal(Human target)
    {
        target.Health = target.Health + (10 * this.Intelligence);
        return target.Health;
    }
}
public class Samurai : Human{

    public Samurai (string name) : base (name)
    {
        Health = 200;
    }

    public override int Attack(Human target)
    {
        base.Attack(target);
        if (target.Health < 50)
        {
            target.Health = 0;
        }
        return target.Health;
    }
    
    public int Meditate(Human target){
        this.Health = 200;
        return this.Health;
    }
}
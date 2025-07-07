public class Archer : GameUnit
{
    public Archer()
    {
        LoadResources();
        Health = 100;
        Attack = 15;
        Defense = 5;
    } 
    public override GameUnit Clone()
    {
        Console.WriteLine("Cloning Archer...");
        return new Archer
        {
            Health = this.Health,
            Attack = this.Attack,
            Defense = this.Defense
        };
    }
} 
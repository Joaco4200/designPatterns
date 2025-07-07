
public class Knight : GameUnit
{
    public Knight()
    {
        LoadResources();
        Health = 200;
        Attack = 20;
        Defense = 10;
    }

    public override GameUnit Clone()
    {
        Console.WriteLine("Cloning Knight");
        return new Knight
        {
            Health = this.Health,
            Attack = this.Attack,
            Defense = this.Defense
        };
    }
} 
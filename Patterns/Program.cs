using Builder;
public class Program {
    public static void Main(string[] args)
    {
        /*ISandwichBuilder builder= new SandwichBuilder();
        SandwichDirector director= new SandwichDirector(builder);
        director.MakeVeggieSandwich();
        Sandwich veggieSandwich= builder.GetResult();
        Console.WriteLine(veggieSandwich);*/

        Console.WriteLine("Creating archer unit...");
        GameUnit archer = new Archer();
        GameUnit clonedArcher = archer.Clone();
    }   
}
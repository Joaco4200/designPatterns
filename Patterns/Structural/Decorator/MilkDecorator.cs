public class MilkDecorator : MarleyMachineDecorator
{
    public MilkDecorator(IMarleyMachine marleyMachine) : base(marleyMachine)
    {
    }
    
    public override void ShowPrice()
    {
        base.ShowPrice();
        Console.WriteLine("+ milk 2.50$");
    }
}
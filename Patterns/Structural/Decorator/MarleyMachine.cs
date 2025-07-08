public class MarleyMachine: IMarleyMachine
{
    public string coffee { get; set; }
    public string milk { get; set; }
    public string sugar { get; set; }

    public void ShowPrice()
    {
        Console.WriteLine("The price of the coffee is $2.00");
    } 
}
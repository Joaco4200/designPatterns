public class Sandwich
{
    public string Bread { get; set; }
    public string Cheese { get; set; }
    public string Meat { get; set; }
    public string Vegetables { get; set; }
    public string Condiments { get; set; }

    public Sandwich(string bread, string cheese, string meat,
        string vegetables, string condiments)
    {
        Bread = bread;
        Cheese = cheese;
        Meat = meat;
        Vegetables = vegetables;
        Condiments = condiments;
    }

    public override string ToString() {
        return $"Sandwich with {Bread} bread, {Cheese} cheese, {Meat} meat, { Vegetables} vegetables, and { Condiments} Condiments";  
    }
}
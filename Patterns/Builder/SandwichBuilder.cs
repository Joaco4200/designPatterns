namespace Builder;
public class SandwichBuilder : ISandwichBuilder
{
    private Sandwich _sandwich = new Sandwich();

    public SandwichBuilder(){}
    public void Reset()
    {
        _sandwich = new Sandwich();
    }

    public void SetBread(string bread)
    {
        _sandwich.Bread = bread;
    }

    public void SetMeat(string meat)
    {
        _sandwich.Meat = meat;
    }

    public void SetCheese(string cheese)
    {
        _sandwich.Cheese = cheese;
    }

    public void SetVegetables(string vegetables)
    {
        _sandwich.Vegetables = vegetables;
    }

    public void SetCondiments(string condiments)
    {
        _sandwich.Condiments = condiments;
    }
    public Sandwich GetResult()
    {
        return _sandwich;
    }
}

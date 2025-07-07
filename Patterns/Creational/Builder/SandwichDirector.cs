namespace Builder;
public class SandwichDirector
{
    private ISandwichBuilder _builder;

    public SandwichDirector(ISandwichBuilder builder)
    {
        _builder = builder;
    }
    
    public void MakeVeggieSandwich()
    {
        _builder.Reset();
        _builder.SetBread("Whole Wheat");
        _builder.SetCheese("Swiss");
        _builder.SetMeat("None");
        _builder.SetVegetables("Lettuce, Tomato, Cucumber");
        _builder.SetCondiments("Mustard");
    }

    public void MakeClubSandwich()
    {
        _builder.Reset();
        _builder.SetBread("White");
        _builder.SetCheese("Cheddar");
        _builder.SetMeat("Turkey, Bacon");
        _builder.SetVegetables("Lettuce, Tomato");
        _builder.SetCondiments("Mayo");
    }
}
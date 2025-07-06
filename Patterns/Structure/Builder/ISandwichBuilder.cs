namespace Builder;
public interface ISandwichBuilder
{
    void Reset();
    void SetBread(string bread);
    void SetCheese(string cheese);
    void SetMeat(string meat);
    void SetVegetables(string vegetables);
    void SetCondiments(string condiments);
    Sandwich GetResult();
}


namespace Composite.Boxes;

public class Product(string name, decimal price) : Item(name)
{
    private decimal Price { get; } = price;

    public override decimal GetPrice()
    {
        return Price;
    }
}
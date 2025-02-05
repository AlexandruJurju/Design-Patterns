namespace Composite.Boxes;

public class Product : Item
{
    public decimal Price { get; }

    public Product(string name, decimal price) : base(name)
    {
        Price = price;
    }

    public override decimal GetPrice()
    {
        return Price;
    }
}
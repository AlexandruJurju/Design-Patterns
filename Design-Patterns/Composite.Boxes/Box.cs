namespace Composite.Boxes;

public class Box(string name) : Item(name)
{
    private readonly List<Item> _items = new();

    public void AddItem(Item item)
    {
        _items.Add(item);
    }

    public override decimal GetPrice()
    {
        decimal totalPrice = 0;

        foreach (var item in _items) totalPrice += item.GetPrice();

        return totalPrice;
    }
}
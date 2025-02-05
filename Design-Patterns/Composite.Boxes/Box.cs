namespace Composite.Boxes;

public class Box : Item
{
    private List<Item> _items = new List<Item>();
    
    public Box(string name) : base(name)
    {
    }

    public void AddItem(Item item)
    {
        _items.Add(item);
    }

    public override decimal GetPrice()
    {
        decimal totalPrice = 0;
        foreach (var item in _items)
        {
            totalPrice += item.GetPrice();
        }
        return totalPrice;
    }
}
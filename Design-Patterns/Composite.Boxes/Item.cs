namespace Composite.Boxes;

public abstract class Item
{
    public string Name { get; }

    protected Item(string name)
    {
        Name = name;
    }

    public abstract decimal GetPrice();
}
namespace Composite.Boxes;

public abstract class Item(string name)
{
    public string Name { get; } = name;

    public abstract decimal GetPrice();
}
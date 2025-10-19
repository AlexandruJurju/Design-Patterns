namespace Composite.Dometrain.Conceptual;

public class Composite : Component
{
    private readonly List<Component> _children = [];

    public override void Operation()
    {
        Console.WriteLine("Composite Operation");

        foreach (var child in _children)
        {
            child.Operation();
        }
    }

    public override void Add(Component component)
    {
        _children.Add(component);
    }

    public override void Remove(Component component)
    {
        _children.Remove(component);
    }

    public override Component? GetChild(int index)
    {
        if (index < 0 || index > _children.Count - 1)
        {
            return null;
        }

        return _children[index];
    }
}
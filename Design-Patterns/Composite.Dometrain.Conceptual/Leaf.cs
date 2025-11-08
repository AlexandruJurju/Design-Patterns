namespace Composite.Dometrain.Conceptual;

public class Leaf : Component
{
    public override void Operation()
    {
        Console.WriteLine("Leaf Operation");
    }
}
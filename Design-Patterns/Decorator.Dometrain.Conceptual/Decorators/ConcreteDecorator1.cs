namespace Decorator.Dometrain.Conceptual.Decorators;

public class ConcreteDecorator1(IComponent component) : Decorator(component)
{
    public override void Operation()
    {
        Console.WriteLine("ConcreteDecorator1");
        component.Operation();
        Console.WriteLine("ConcreteDecorator1");
    }
}
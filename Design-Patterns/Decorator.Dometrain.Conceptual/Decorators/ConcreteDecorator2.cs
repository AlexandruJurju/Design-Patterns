namespace Decorator.Dometrain.Conceptual.Decorators;

public class ConcreteDecorator2(IComponent component) : Decorator(component)
{
    public override void Operation()
    {
        Console.WriteLine("ConcreteDecorator2");
        component.Operation();
        Console.WriteLine("ConcreteDecorator2");
    }
}
using Decorator.Components;

namespace Decorator.Decorators;

public class ConcreteDecoratorA(Component component) : Decorator(component)
{
    public override string Operation()
    {
        return $"ConcreteDecoratorA({base.Operation()})";
    }
}
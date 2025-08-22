using Decorator.Conceptual.Components;

namespace Decorator.Conceptual.Decorators;

public class ConcreteDecoratorA(Component component) : Decorator(component)
{
    public override string Operation()
    {
        return $"ConcreteDecoratorA({base.Operation()})";
    }
}
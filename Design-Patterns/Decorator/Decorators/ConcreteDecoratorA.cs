using Decorator.Components;

namespace Decorator.Decorators;

public class ConcreteDecoratorA : Decorator
{
    public ConcreteDecoratorA(Component component) : base(component)
    {
        
    }
    
    public override string Operation()
    {
        return $"ConcreteDecoratorA({base.Operation()})";
    }
}
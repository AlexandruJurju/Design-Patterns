using Decorator.Components;

namespace Decorator.Decorators;

internal class ConcreteDecoratorB(Component comp) : Decorator(comp)
{
    public override string Operation()
    {
        return $"ConcreteDecoratorB({base.Operation()})";
    }
}
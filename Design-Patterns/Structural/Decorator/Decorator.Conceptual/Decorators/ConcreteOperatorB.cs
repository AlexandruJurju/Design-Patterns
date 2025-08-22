using Decorator.Conceptual.Components;

namespace Decorator.Conceptual.Decorators;

internal class ConcreteDecoratorB(Component comp) : Decorator(comp)
{
    public override string Operation()
    {
        return $"ConcreteDecoratorB({base.Operation()})";
    }
}
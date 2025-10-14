using Decorator.Starbuzz.Components;

namespace Decorator.Starbuzz.Decorators;

public abstract class CondimentDecorator : Beverage
{
    public abstract override string Description { get; }
}
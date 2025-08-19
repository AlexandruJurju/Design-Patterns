using Decorator.Starbuzz.Components;

namespace Decorator.Starbuzz.Decorators;

public class Soy : CondimentDecorator
{
    private readonly Beverage _beverage;

    public Soy(Beverage beverage)
    {
        _beverage = beverage;
    }

    public override string Description => _beverage.Description + ", Soy";

    public override double Cost()
    {
        return 0.75 + _beverage.Cost();
    }
}
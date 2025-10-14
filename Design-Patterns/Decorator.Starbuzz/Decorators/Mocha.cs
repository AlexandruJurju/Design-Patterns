using Decorator.Starbuzz.Components;

namespace Decorator.Starbuzz.Decorators;

public class Mocha : CondimentDecorator
{
    private readonly Beverage _beverage;

    public Mocha(Beverage beverage)
    {
        _beverage = beverage;
    }

    public override string Description => _beverage.Description + " Mocha";

    public override double Cost()
    {
        return 0.2 + _beverage.Cost();
    }
}
namespace Decorator.Starbuzz.Components;

internal sealed class Espresso : Beverage
{
    public Espresso()
    {
        Description = "Espresso";
    }

    public override double Cost()
    {
        return 0.5;
    }
}
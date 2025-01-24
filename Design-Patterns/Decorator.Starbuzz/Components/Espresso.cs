namespace Decorator.Starbuzz.Components;

sealed class Espresso : Beverage
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
using Strategy.DuckHFDF.Strategies.Abstractions;

namespace Strategy.DuckHFDF.Strategies;

public class FlyNoWay : IFlyBehavior
{
    public void Fly()
    {
        Console.WriteLine("I can't fly");
    }
}
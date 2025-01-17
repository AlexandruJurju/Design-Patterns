using Strategy.DuckHFDF.Strategies.Abstractions;

namespace Strategy.DuckHFDF.Strategies;

public class FlyRocketPowered : IFlyBehavior
{
    public void Fly()
    {
        Console.WriteLine("I'm flying with a rocket!");
    }
}
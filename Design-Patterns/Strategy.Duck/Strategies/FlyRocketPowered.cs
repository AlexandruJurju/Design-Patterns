using Strategy.Duck.Strategies.Abstractions;

namespace Strategy.Duck.Strategies;

public class FlyRocketPowered : IFlyBehavior
{
    public void Fly()
    {
        Console.WriteLine("I'm flying with a rocket!");
    }
}
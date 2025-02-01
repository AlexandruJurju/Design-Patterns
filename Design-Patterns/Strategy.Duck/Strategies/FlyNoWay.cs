using Strategy.Duck.Strategies.Abstractions;

namespace Strategy.Duck.Strategies;

public class FlyNoWay : IFlyBehavior
{
    public void Fly()
    {
        Console.WriteLine("I can't fly");
    }
}
using Strategy.Duck.Strategies.Abstractions;

namespace Strategy.Duck.Strategies;

public class FlyWithWings : IFlyBehavior
{
    public void Fly()
    {
        Console.WriteLine("I'm flying!!");
    }
}
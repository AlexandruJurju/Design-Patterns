using Strategy.Duck.Strategies;
using Strategy.Duck.Ducks.Abstractions;

namespace Strategy.Duck.Ducks;

public class RedHeadDuck : Abstractions.Duck
{
    public RedHeadDuck()
    {
        QuackBehavior = new Quack();
        FlyBehavior = new FlyWithWings();
    }

    public override void Display()
    {
        Console.WriteLine("I'm a real Red Headed duck");
    }
}
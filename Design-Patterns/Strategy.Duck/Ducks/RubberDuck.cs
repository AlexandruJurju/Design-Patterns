using Strategy.Duck.Strategies;
using Strategy.Duck.Ducks.Abstractions;

namespace Strategy.Duck.Ducks;

public class RubberDuck : Abstractions.Duck
{
    public RubberDuck()
    {
        QuackBehavior = new Squeak();
        FlyBehavior = new FlyNoWay();
    }

    public override void Display()
    {
        Console.WriteLine("I'm a rubber duckie");
    }
}
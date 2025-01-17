using Strategy.DuckHFDF.Ducks.Abstractions;
using Strategy.DuckHFDF.Strategies;

namespace Strategy.DuckHFDF.Ducks;

public class RubberDuck : Duck
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
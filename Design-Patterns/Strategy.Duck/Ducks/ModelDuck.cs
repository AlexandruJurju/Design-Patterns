using Strategy.Duck.Strategies;
using Strategy.Duck.Ducks.Abstractions;

namespace Strategy.Duck.Ducks;

public class ModelDuck : Abstractions.Duck
{
    public ModelDuck()
    {
        FlyBehavior = new FlyNoWay();
        QuackBehavior = new Quack();
    }

    public override void Display()
    {
        Console.WriteLine("I'm a model duck");
    }
}
using Strategy.DuckHFDF.Ducks.Abstractions;
using Strategy.DuckHFDF.Strategies;

namespace Strategy.DuckHFDF.Ducks;

public class ModelDuck : Duck
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
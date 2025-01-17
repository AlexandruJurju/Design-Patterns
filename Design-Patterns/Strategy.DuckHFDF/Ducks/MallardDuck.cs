using Strategy.DuckHFDF.Strategies;

namespace Strategy.DuckHFDF.Ducks;

public class MallardDuck : Abstractions.Duck

{
    public MallardDuck()
    {
        QuackBehavior = new Quack();
        FlyBehavior = new FlyWithWings();
    }

    public override void Display()
    {
        Console.WriteLine("I'm a real Mallard duck");
    }
}
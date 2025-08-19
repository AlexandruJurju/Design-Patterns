using Strategy.Duck.Strategies;

namespace Strategy.Duck.Ducks;

public class DecoyDuck : Abstractions.Duck
{
    public DecoyDuck()
    {
        QuackBehavior = new MuteQuack();
        FlyBehavior = new FlyNoWay();
    }

    public override void Display()
    {
        Console.WriteLine("I'm a duck Decoy");
    }
}
using Strategy.Duck.Strategies.Abstractions;

namespace Strategy.Duck.Strategies;

public class Squeak : IQuackBehavior
{
    public void Quack()
    {
        Console.WriteLine("Squeak");
    }
}
using Strategy.Duck.Strategies.Abstractions;

namespace Strategy.Duck.Strategies;

public class Quack : IQuackBehavior
{
    void IQuackBehavior.Quack()
    {
        Console.WriteLine("Quack");
    }
}
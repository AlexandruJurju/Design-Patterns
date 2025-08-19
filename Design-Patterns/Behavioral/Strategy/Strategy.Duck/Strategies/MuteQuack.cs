using Strategy.Duck.Strategies.Abstractions;

namespace Strategy.Duck.Strategies;

public class MuteQuack : IQuackBehavior
{
    public void Quack()
    {
        Console.WriteLine("<< Silence >>");
    }
}
using Strategy.DuckHFDF.Strategies.Abstractions;

namespace Strategy.DuckHFDF.Strategies;

public class Squeak : IQuackBehavior
{
    public void Quack()
    {
        Console.WriteLine("Squeak");
    }
}
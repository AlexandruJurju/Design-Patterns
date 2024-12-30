namespace Strategy.DuckBehaviors.Quack;

public class Squeak : IQuackBehavior
{
    public void Quack()
    {
        Console.WriteLine("squeak");
    }
}
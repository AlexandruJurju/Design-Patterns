namespace Strategy.DuckBehaviors.Quack;

public class NormalQuack : IQuackBehavior
{
    public void Quack()
    {
        Console.WriteLine("normal quack");
    }
}
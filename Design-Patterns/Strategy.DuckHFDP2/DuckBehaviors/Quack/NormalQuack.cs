namespace Strategy.DuckHFDP2.DuckBehaviors.Quack;

public class NormalQuack : IQuackBehavior
{
    public void Quack()
    {
        Console.WriteLine("normal quack");
    }
}
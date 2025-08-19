namespace DuckSimulator.Decorator;

public class QuackCounter : IQuackable
{
    private readonly IQuackable _duck;

    public QuackCounter(IQuackable duck)
    {
        _duck = duck;
    }

    public static int NumberOfQuacks { get; private set; }

    public void Quack()
    {
        _duck.Quack();
        NumberOfQuacks++;
    }
}
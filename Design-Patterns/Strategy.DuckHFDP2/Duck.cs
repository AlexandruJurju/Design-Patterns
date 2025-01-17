using Strategy.DuckHFDP2.DuckBehaviors.Fly;
using Strategy.DuckHFDP2.DuckBehaviors.Quack;

namespace Strategy.DuckHFDP2;

public class Duck
{
    private readonly IFlyBehavior _flyBehavior;
    private readonly IQuackBehavior _quackBehavior;

    public Duck(IFlyBehavior flyBehavior, IQuackBehavior quackBehavior)
    {
        _flyBehavior = flyBehavior;
        _quackBehavior = quackBehavior;
    }

    public void PerformQuack()
    {
        _quackBehavior.Quack();
    }

    public void PerformFly()
    {
        _flyBehavior.Fly();
    }
}
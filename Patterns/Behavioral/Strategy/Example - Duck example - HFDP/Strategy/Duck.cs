using Strategy.DuckBehaviors.Fly;
using Strategy.DuckBehaviors.Quack;

namespace Strategy;

public class Duck
{
    private IFlyBehavior _flyBehavior;
    private IQuackBehavior _quackBehavior;

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
using Strategy.DuckHFDF.Strategies.Abstractions;

namespace Strategy.DuckHFDF.Strategies
{
    public class Quack : IQuackBehavior
    {
        void IQuackBehavior.Quack()
        {
            Console.WriteLine("Quack");
        }
    }
}

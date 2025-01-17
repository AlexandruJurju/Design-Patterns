using Strategy.DuckHFDF.Strategies.Abstractions;

namespace Strategy.DuckHFDF.Strategies
{
    public class FlyWithWings : IFlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("I'm flying!!");
        }
    }
}

using Strategy.DuckHFDF.Ducks.Abstractions;
using Strategy.DuckHFDF.Strategies;

namespace Strategy.DuckHFDF.Ducks
{
    public class RedHeadDuck : Duck
    {
        public RedHeadDuck()
        {
            QuackBehavior = new Quack();
            FlyBehavior = new FlyWithWings();
        }

        public override void Display()
        {
            Console.WriteLine("I'm a real Red Headed duck");
        }
    }
}
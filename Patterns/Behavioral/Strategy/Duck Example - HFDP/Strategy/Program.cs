using Strategy;
using Strategy.DuckBehaviors.Fly;
using Strategy.DuckBehaviors.Quack;

Duck duck = new Duck(new FlyWithMagic(), new NormalQuack());
duck.PerformFly();
duck.PerformQuack();

Duck duck2 = new Duck(new FlyWithWings(), new Squeak());
duck2.PerformFly();
duck2.PerformQuack();
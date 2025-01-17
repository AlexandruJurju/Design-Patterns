using Strategy.DuckHFDP2;
using Strategy.DuckHFDP2.DuckBehaviors.Fly;
using Strategy.DuckHFDP2.DuckBehaviors.Quack;

Duck duck = new Duck(new FlyWithMagic(), new NormalQuack());
duck.PerformFly();
duck.PerformQuack();

Duck duck2 = new Duck(new FlyWithWings(), new Squeak());
duck2.PerformFly();
duck2.PerformQuack();
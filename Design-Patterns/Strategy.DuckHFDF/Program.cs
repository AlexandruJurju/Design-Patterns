using Strategy.DuckHFDF.Ducks;
using Strategy.DuckHFDF.Strategies;

MallardDuck mallard = new MallardDuck();
RubberDuck rubberDuckie = new RubberDuck();
DecoyDuck decoy = new DecoyDuck();

ModelDuck model = new ModelDuck();

mallard.PerformQuack();
rubberDuckie.PerformQuack();
decoy.PerformQuack();

Console.WriteLine();

model.PerformFly();
model.FlyBehavior = new FlyRocketPowered();
model.PerformFly();
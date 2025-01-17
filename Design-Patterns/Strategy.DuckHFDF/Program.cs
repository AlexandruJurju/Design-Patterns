﻿using Strategy.DuckHFDF.Ducks;
using Strategy.DuckHFDF.Strategies;

var mallard = new MallardDuck();
var rubberDuckie = new RubberDuck();
var decoy = new DecoyDuck();

var model = new ModelDuck();

mallard.PerformQuack();
rubberDuckie.PerformQuack();
decoy.PerformQuack();

Console.WriteLine();

model.PerformFly();
model.FlyBehavior = new FlyRocketPowered();
model.PerformFly();
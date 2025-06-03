using DuckSimulator;
using DuckSimulator.Adapter;
using DuckSimulator.Composite;
using DuckSimulator.Decorator;
using DuckSimulator.Factories;

AbstractDuckFactory duckFactory = new CountingDuckFactory();

var redheadDuck = duckFactory.CreateRedheadDuck();
var duckCall = duckFactory.CreateDuckCall();
var rubberDuck = duckFactory.CreateRubberDuck();
IQuackable gooseDuck = new QuackCounter(new GooseAdapter(new Goose()));

var flockOfDucks = new Flock();
flockOfDucks.Add(redheadDuck);
flockOfDucks.Add(duckCall);
flockOfDucks.Add(rubberDuck);
flockOfDucks.Add(gooseDuck);
flockOfDucks.Quack();
Console.WriteLine(QuackCounter.NumberOfQuacks);

var flockOfMallards = new Flock();
var mallardOne = duckFactory.CreateMallardDuck();
var mallardTwo = duckFactory.CreateMallardDuck();
var mallardThree = duckFactory.CreateMallardDuck();
var mallardFour = duckFactory.CreateMallardDuck();
using DuckSimulator;
using DuckSimulator.Adapter;
using DuckSimulator.Composite;
using DuckSimulator.Decorator;
using DuckSimulator.Factories;

AbstractDuckFactory duckFactory = new CountingDuckFactory();

IQuackable redheadDuck = duckFactory.CreateRedheadDuck();
IQuackable duckCall = duckFactory.CreateDuckCall();
IQuackable rubberDuck = duckFactory.CreateRubberDuck();
IQuackable gooseDuck = new QuackCounter(new GooseAdapter(new Goose()));

Flock flockOfDucks = new Flock();
flockOfDucks.Add(redheadDuck);
flockOfDucks.Add(duckCall);
flockOfDucks.Add(rubberDuck);
flockOfDucks.Add(gooseDuck);
flockOfDucks.Quack();
Console.WriteLine(QuackCounter.NumberOfQuacks);

Flock flockOfMallards = new Flock();
IQuackable mallardOne = duckFactory.CreateMallardDuck();
IQuackable mallardTwo = duckFactory.CreateMallardDuck();
IQuackable mallardThree = duckFactory.CreateMallardDuck();
IQuackable mallardFour = duckFactory.CreateMallardDuck();
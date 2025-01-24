using Decorator.Starbuzz.Components;
using Decorator.Starbuzz.Decorators;

Beverage beverage = new Espresso();
Console.WriteLine(beverage.Description + " $" + beverage.Cost());

Beverage beverage2 = new DarkRoast();
beverage2 = new Mocha(beverage2);
beverage2 = new Mocha(beverage2);
Console.WriteLine(beverage2.Description + " $" + beverage2.Cost());
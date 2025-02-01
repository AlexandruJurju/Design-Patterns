using Decorator.Components;
using Decorator.Decorators;

var simple = new ConcreteComponent();
Console.WriteLine("Client: I get a simple component");
Console.WriteLine(simple.Operation());
Console.WriteLine();


ConcreteDecoratorA decorator1 = new ConcreteDecoratorA(simple);
ConcreteDecoratorB decorator2 = new ConcreteDecoratorB(decorator1);
Console.WriteLine("Client: Now I've got a decorated component:");
Console.WriteLine(decorator2.Operation());

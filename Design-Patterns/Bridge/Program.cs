using Bridge.Abstraction;
using Bridge.Implementation;

var abstraction = new Abstraction(new ConcreteImplementationA());
Console.Write(abstraction.Operation());
Console.WriteLine();

abstraction = new ExtendedAbstraction(new ConcreteImplementationB());
Console.Write(abstraction.Operation());
Console.WriteLine();
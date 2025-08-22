using Bridge.Conceptual.Abstraction;
using Bridge.Conceptual.Implementation;

var abstraction = new Abstraction(new ConcreteImplementationA());
Console.Write(abstraction.Operation());
Console.WriteLine();

abstraction = new ExtendedAbstraction(new ConcreteImplementationB());
Console.Write(abstraction.Operation());
Console.WriteLine();
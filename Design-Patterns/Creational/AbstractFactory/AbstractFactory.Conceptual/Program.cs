using AbstractFactory.Conceptual.AbstractFactories;

IAbstractFactory factory1 = new ConcreteFactory1();

var productA1 = factory1.CreateProductA();
Console.WriteLine(productA1.UsefulFunctionA());
var productB1 = factory1.CreateProductB();
Console.WriteLine(productB1.UsefulFunctionB());
Console.WriteLine();

IAbstractFactory factory2 = new ConcreteFactory2();

var productA2 = factory2.CreateProductA();
Console.WriteLine(productA2.UsefulFunctionA());
var productB2 = factory2.CreateProductB();
Console.WriteLine(productB2.UsefulFunctionB());
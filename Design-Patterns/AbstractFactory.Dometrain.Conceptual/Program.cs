using AbstractFactory.Dometrain.Conceptual.Factories;
using AbstractFactory.Dometrain.Conceptual.Products;

var abstractFactory = new ConcreteFactoryA();

var product1a = abstractFactory.CreateProduct1();
var product2a = abstractFactory.CreateProduct2();
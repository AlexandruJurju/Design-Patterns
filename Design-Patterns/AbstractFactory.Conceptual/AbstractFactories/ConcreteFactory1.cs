using AbstractFactory.Conceptual.Products;
using AbstractFactory.Conceptual.Products.ConcreteProducts1;

namespace AbstractFactory.Conceptual.AbstractFactories;

public class ConcreteFactory1 : IAbstractFactory
{
    public IAbstractProductA CreateProductA()
    {
        return new ConcreteProductA1();
    }

    public IAbstractProductB CreateProductB()
    {
        return new ConcreteProductB1();
    }
}
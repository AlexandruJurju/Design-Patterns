using AbstractFactory.Products;
using AbstractFactory.Products.ConcreteProducts1;

namespace AbstractFactory.AbstractFactories;

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
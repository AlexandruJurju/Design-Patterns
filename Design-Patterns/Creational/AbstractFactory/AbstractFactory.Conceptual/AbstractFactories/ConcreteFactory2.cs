using AbstractFactory.Conceptual.Products;
using AbstractFactory.Conceptual.Products.ConcreteProducts2;

namespace AbstractFactory.Conceptual.AbstractFactories;

public class ConcreteFactory2 : IAbstractFactory
{
    public IAbstractProductA CreateProductA()
    {
        return new ConcreteProductA2();
    }

    public IAbstractProductB CreateProductB()
    {
        return new ConcreteProductB2();
    }
}
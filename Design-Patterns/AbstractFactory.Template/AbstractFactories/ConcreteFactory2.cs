using AbstractFactory.Template.Products;
using AbstractFactory.Template.Products.ConcreteProducts2;

namespace AbstractFactory.Template.AbstractFactories;

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
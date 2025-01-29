using AbstractFactory.Template.Products;
using AbstractFactory.Template.Products.ConcreteProducts1;

namespace AbstractFactory.Template.AbstractFactories;

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
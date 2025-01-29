using AbstractFactory.Template.Products;

namespace AbstractFactory.Template.AbstractFactories;

public interface IAbstractFactory
{
    IAbstractProductA CreateProductA();

    IAbstractProductB CreateProductB();
}
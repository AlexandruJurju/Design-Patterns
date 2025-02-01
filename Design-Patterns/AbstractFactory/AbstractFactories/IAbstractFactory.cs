using AbstractFactory.Products;

namespace AbstractFactory.AbstractFactories;

public interface IAbstractFactory
{
    IAbstractProductA CreateProductA();

    IAbstractProductB CreateProductB();
}
using AbstractFactory.Conceptual.Products;

namespace AbstractFactory.Conceptual.AbstractFactories;

public interface IAbstractFactory
{
    IAbstractProductA CreateProductA();

    IAbstractProductB CreateProductB();
}
using AbstractFactory.Furniture.Products;

namespace AbstractFactory.Furniture.AbstractFactories;

public interface IAbstractFactory
{
    IChair CreateChair();
    ICouch CreateCouch();
    ITable CreateTable();
}
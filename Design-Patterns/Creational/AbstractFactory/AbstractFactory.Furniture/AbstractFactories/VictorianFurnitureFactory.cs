using AbstractFactory.Furniture.Products;
using AbstractFactory.Furniture.Products.Victorian;

namespace AbstractFactory.Furniture.AbstractFactories;

public class VictorianFurnitureFactory : IAbstractFactory
{
    public IChair CreateChair()
    {
        return new VictorianChair();
    }

    public ICouch CreateCouch()
    {
        return new VictorianCouch();
    }

    public ITable CreateTable()
    {
        return new VictorianTable();
    }
}
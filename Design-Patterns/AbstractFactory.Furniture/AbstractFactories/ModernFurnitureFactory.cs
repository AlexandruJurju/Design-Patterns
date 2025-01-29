using AbstractFactory.Furniture.Products;
using AbstractFactory.Furniture.Products.Modern;

namespace AbstractFactory.Furniture.AbstractFactories;

public class ModernFurnitureFactory : IAbstractFactory
{
    public IChair CreateChair()
    {
        return new ModernChair();
    }

    public ICouch CreateCouch()
    {
        return new ModernCouch();
    }

    public ITable CreateTable()
    {
        return new ModernTable();
    }
}
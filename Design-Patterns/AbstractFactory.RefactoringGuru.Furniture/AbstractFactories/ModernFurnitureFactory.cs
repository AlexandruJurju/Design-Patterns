using AbstractFactory.RefactoringGuru.Furniture.Products;
using AbstractFactory.RefactoringGuru.Furniture.Products.Modern;

namespace AbstractFactory.RefactoringGuru.Furniture.AbstractFactories;

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
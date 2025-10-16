using AbstractFactory.RefactoringGuru.Furniture.Products;
using AbstractFactory.RefactoringGuru.Furniture.Products.Victorian;

namespace AbstractFactory.RefactoringGuru.Furniture.AbstractFactories;

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
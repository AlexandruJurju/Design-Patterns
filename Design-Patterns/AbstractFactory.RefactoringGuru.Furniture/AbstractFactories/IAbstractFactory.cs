using AbstractFactory.RefactoringGuru.Furniture.Products;

namespace AbstractFactory.RefactoringGuru.Furniture.AbstractFactories;

public interface IAbstractFactory
{
    IChair CreateChair();
    ICouch CreateCouch();
    ITable CreateTable();
}
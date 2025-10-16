namespace AbstractFactory.RefactoringGuru.Furniture.Products.Modern;

public class ModernTable : ITable
{
    public string Eat()
    {
        return "Eating from a modern table";
    }
}
namespace AbstractFactory.RefactoringGuru.Furniture.Products.Victorian;

public class VictorianTable : ITable
{
    public string Eat()
    {
        return "Eating from a victorian table";
    }
}
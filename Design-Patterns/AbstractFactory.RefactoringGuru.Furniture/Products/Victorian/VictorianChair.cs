namespace AbstractFactory.RefactoringGuru.Furniture.Products.Victorian;

public class VictorianChair : IChair
{
    public string Sit()
    {
        return "Sitting on a victorian chair";
    }
}
namespace AbstractFactory.Furniture.Products.Modern;

public class ModernChair : IChair
{
    public string Sit()
    {
        return "Sitting on a modern chair";
    }
}
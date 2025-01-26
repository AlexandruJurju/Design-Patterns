namespace Factory.Transportation.Products;

public class Car : ITransport
{
    public string Deliver()
    {
        return "Car transportation";
    }
}
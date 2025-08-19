namespace FactoryMethod.Transportation.Products;

public class Plane : ITransport
{
    public string Deliver()
    {
        return "Plane transportation";
    }
}
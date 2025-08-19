using FactoryMethod.Transportation.Products;

namespace FactoryMethod.Transportation.Creators;

public abstract class Logistics
{
    public abstract ITransport CreateTransport();

    public string Deliver()
    {
        var transport = CreateTransport();

        return $"Moving with {transport.Deliver()}";
    }
}
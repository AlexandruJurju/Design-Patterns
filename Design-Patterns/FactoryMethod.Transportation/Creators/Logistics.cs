using FactoryMethod.Transportation.Products;

namespace FactoryMethod.Transportation.Creators;

public abstract class Logistics
{
    public abstract ITransport CreateTransport();

    public string Deliver()
    {
        ITransport transport = CreateTransport();

        return $"Moving with {transport.Deliver()}";
    }
}
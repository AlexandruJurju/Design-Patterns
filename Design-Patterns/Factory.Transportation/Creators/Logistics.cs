using Factory.Transportation.Products;

namespace Factory.Transportation.Creators;

public abstract class Logistics
{
    public abstract ITransport CreateTransport();

    public string Deliver()
    {
        ITransport transport = CreateTransport();

        return $"Moving with {transport.Deliver()}";
    }
}
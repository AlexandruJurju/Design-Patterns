using FactoryMethod.Transportation.Products;

namespace FactoryMethod.Transportation.Creators;

public class AirLogistics : Logistics
{
    protected override ITransport CreateTransport()
    {
        return new Plane();
    }
}
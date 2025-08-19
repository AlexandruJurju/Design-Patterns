using FactoryMethod.Transportation.Products;

namespace FactoryMethod.Transportation.Creators;

public class AirLogistics : Logistics
{
    public override ITransport CreateTransport()
    {
        return new Plane();
    }
}
using FactoryMethod.Transportation.Products;

namespace FactoryMethod.Transportation.Creators;

public class RoadLogistics : Logistics
{
    protected override ITransport CreateTransport()
    {
        return new Car();
    }
}
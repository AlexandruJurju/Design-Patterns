using FactoryMethod.Transportation.Products;

namespace FactoryMethod.Transportation.Creators;

public class RoadLogistics : Logistics
{
    public override ITransport CreateTransport()
    {
        return new Car();
    }
}
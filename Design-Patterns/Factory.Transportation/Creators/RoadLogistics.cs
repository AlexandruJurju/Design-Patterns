using Factory.Transportation.Products;

namespace Factory.Transportation.Creators;

public class RoadLogistics : Logistics
{
    public override ITransport CreateTransport()
    {
        return new Car();
    }
}
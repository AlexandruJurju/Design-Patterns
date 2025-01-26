using Factory.Transportation.Products;

namespace Factory.Transportation.Creators;

public class AirLogistics : Logistics
{
    public override ITransport CreateTransport()
    {
        return new Plane();
    }
}
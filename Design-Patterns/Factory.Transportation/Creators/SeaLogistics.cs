using Factory.Transportation.Products;

namespace Factory.Transportation.Creators;

public class SeaLogistics : Logistics
{
    public override ITransport CreateTransport()
    {
        return new Ship();
    }
}
using FactoryMethod.Transportation.Products;

namespace FactoryMethod.Transportation.Creators;

public class SeaLogistics : Logistics
{
    public override ITransport CreateTransport()
    {
        return new Ship();
    }
}
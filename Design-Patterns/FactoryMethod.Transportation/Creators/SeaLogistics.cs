using FactoryMethod.Transportation.Products;

namespace FactoryMethod.Transportation.Creators;

public class SeaLogistics : Logistics
{
    protected override ITransport CreateTransport()
    {
        return new Ship();
    }
}
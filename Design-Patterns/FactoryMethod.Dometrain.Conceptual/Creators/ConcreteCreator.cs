using FactoryMethod.Dometrain.Conceptual.Products;

namespace FactoryMethod.Dometrain.Conceptual.Creators;

public class ConcreteCreator : Creator
{
    public override IProduct CreateProduct()
    {
        return new ConcreteProduct();
    }
}
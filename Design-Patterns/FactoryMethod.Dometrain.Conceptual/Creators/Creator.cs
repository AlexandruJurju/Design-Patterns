using FactoryMethod.Dometrain.Conceptual.Products;

namespace FactoryMethod.Dometrain.Conceptual.Creators;

public abstract class Creator
{
    public abstract IProduct CreateProduct();
}
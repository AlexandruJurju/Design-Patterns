using FactoryMethod.Conceptual.Products;

namespace FactoryMethod.Conceptual.Creators;

public class ConcreteCreator2 : Creator
{
    protected override IProduct FactoryMethod()
    {
        return new ConcreteProduct2();
    }
}
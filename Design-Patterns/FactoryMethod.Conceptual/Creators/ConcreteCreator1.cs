using FactoryMethod.Conceptual.Products;

namespace FactoryMethod.Conceptual.Creators;

public class ConcreteCreator1 : Creator
{
    protected override IProduct FactoryMethod()
    {
        return new ConcreteProduct1();
    }
}
using FactoryMethod.Products;

namespace FactoryMethod.Creators;

public class ConcreteCreator1 : Creator
{
    public override IProduct FactoryMethod()
    {
        return new ConcreteProduct1();
    }
}
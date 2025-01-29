using FactoryMethod.Template.Products;

namespace FactoryMethod.Template.Creators;

public class ConcreteCreator1 : Creator
{
    public override IProduct FactoryMethod()
    {
        return new ConcreteProduct1();
    }
}
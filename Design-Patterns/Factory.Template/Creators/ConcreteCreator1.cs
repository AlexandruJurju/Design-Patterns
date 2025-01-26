using Factory.Template.Products;

namespace Factory.Template.Creators;

public class ConcreteCreator1 : Creator
{
    public override IProduct FactoryMethod()
    {
        return new ConcreteProduct1();
    }
}
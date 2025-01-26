using Factory.Template.Products;

namespace Factory.Template.Creators;

public abstract class Creator
{
    public abstract IProduct FactoryMethod();

    public string SomeOperation()
    {
        var product = FactoryMethod();

        var result = "Creator: The same creator's code has just worked with " + product.Operation();

        return result;
    }
}
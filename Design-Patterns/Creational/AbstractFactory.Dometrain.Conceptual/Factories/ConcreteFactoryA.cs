using AbstractFactory.Dometrain.Conceptual.Products;

namespace AbstractFactory.Dometrain.Conceptual.Factories;

public class ConcreteFactoryA : AbstractFactory
{
    public override IProduct1 CreateProduct1()
    {
        return new ConcreteProduct1A();
    }

    public override IProduct2 CreateProduct2()
    {
        return new ConcreteProduct2A();
    }
}
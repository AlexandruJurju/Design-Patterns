using AbstractFactory.Dometrain.Conceptual.Products;

namespace AbstractFactory.Dometrain.Conceptual.Factories;

public class ConcreteFactoryB : AbstractFactory
{
    public override IProduct1 CreateProduct1()
    {
        return new ConcreteProduct1B();
    }

    public override IProduct2 CreateProduct2()
    {
        return new ConcreteProduct2B();
    }
}
using AbstractFactory.Dometrain.Conceptual.Products;

namespace AbstractFactory.Dometrain.Conceptual.Factories;

public abstract class AbstractFactory
{
    public abstract IProduct1 CreateProduct1();
    public abstract IProduct2 CreateProduct2();
}
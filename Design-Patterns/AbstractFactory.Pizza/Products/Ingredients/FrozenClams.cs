using AbstractFactory.Pizza.Products.Ingredients.Abstractions;

namespace AbstractFactory.Pizza.Products.Ingredients;

public class FrozenClams : IClams
{
    public string Name => "Frozen Clams";
}
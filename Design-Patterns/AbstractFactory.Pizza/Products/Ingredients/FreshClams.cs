using AbstractFactory.Pizza.Products.Ingredients.Abstractions;

namespace AbstractFactory.Pizza.Products.Ingredients;

public class FreshClams : IClams
{
    public string Name => "Fresh Clams";
}
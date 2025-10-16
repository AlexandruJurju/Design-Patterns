using AbstractFactory.HeadFirst.Pizza.Products.Ingredients.Abstractions;

namespace AbstractFactory.HeadFirst.Pizza.Products.Ingredients;

public class FreshClams : IClams
{
    public string Name => "Fresh Clams";
}
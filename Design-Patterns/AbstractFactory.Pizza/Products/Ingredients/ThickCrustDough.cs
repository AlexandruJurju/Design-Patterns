using AbstractFactory.Pizza.Products.Ingredients.Abstractions;

namespace AbstractFactory.Pizza.Products.Ingredients;

public class ThickCrustDough : IDough
{
    public string Name => "ThickCrust Dough";
}
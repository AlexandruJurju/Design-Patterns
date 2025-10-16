using AbstractFactory.HeadFirst.Pizza.Products.Ingredients.Abstractions;

namespace AbstractFactory.HeadFirst.Pizza.Products.Ingredients;

public class ThickCrustDough : IDough
{
    public string Name => "ThickCrust Dough";
}
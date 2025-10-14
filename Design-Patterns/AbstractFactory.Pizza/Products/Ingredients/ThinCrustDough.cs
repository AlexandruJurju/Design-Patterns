using AbstractFactory.Pizza.Products.Ingredients.Abstractions;

namespace AbstractFactory.Pizza.Products.Ingredients;

public class ThinCrustDough : IDough
{
    public string Name => "Thin Crust Dough";
}
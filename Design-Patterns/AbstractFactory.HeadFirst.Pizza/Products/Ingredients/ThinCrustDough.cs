using AbstractFactory.HeadFirst.Pizza.Products.Ingredients.Abstractions;

namespace AbstractFactory.HeadFirst.Pizza.Products.Ingredients;

public class ThinCrustDough : IDough
{
    public string Name => "Thin Crust Dough";
}
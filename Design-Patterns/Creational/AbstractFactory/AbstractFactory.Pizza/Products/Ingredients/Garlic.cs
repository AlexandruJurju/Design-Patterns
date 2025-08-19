using AbstractFactory.Pizza.Products.Ingredients.Abstractions;

namespace AbstractFactory.Pizza.Products.Ingredients;

public class Garlic : IVeggies
{
    public string Name => "Garlic";
}
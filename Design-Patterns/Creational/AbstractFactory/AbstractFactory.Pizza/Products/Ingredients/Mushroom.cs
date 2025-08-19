using AbstractFactory.Pizza.Products.Ingredients.Abstractions;

namespace AbstractFactory.Pizza.Products.Ingredients;

public class Mushroom : IVeggies
{
    public string Name => "Mushroom";
}
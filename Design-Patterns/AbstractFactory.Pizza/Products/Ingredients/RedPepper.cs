using AbstractFactory.Pizza.Products.Ingredients.Abstractions;

namespace AbstractFactory.Pizza.Products.Ingredients;

public class RedPepper : IVeggies
{
    public string Name => "Red Pepper";
}
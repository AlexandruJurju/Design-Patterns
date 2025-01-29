using AbstractFactory.Pizza.Products.Ingredients.Abstractions;

namespace AbstractFactory.Pizza.Products.Ingredients;

public class Spinach : IVeggies
{
    public string Name => "Spinach";
}
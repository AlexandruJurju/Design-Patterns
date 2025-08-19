using AbstractFactory.Pizza.Products.Ingredients.Abstractions;

namespace AbstractFactory.Pizza.Products.Ingredients;

public class ReggianoCheese : ICheese
{
    public string Name => "Reggiano Cheese";
}
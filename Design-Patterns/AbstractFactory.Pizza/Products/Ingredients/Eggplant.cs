using AbstractFactory.Pizza.Products.Ingredients.Abstractions;

namespace AbstractFactory.Pizza.Products.Ingredients;

public class Eggplant : IVeggies
{
    public string Name => "Eggplant";
}
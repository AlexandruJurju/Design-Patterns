using AbstractFactory.HeadFirst.Pizza.Products.Ingredients.Abstractions;

namespace AbstractFactory.HeadFirst.Pizza.Products.Ingredients;

public class Mushroom : IVeggies
{
    public string Name => "Mushroom";
}
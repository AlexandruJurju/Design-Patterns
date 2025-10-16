using AbstractFactory.HeadFirst.Pizza.Products.Ingredients.Abstractions;

namespace AbstractFactory.HeadFirst.Pizza.Products.Ingredients;

public class Garlic : IVeggies
{
    public string Name => "Garlic";
}
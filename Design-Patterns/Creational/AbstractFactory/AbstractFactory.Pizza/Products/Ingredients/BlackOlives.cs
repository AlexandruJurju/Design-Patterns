using AbstractFactory.Pizza.Products.Ingredients.Abstractions;

namespace AbstractFactory.Pizza.Products.Ingredients;

public class BlackOlives : IVeggies
{
    public string Name => "Black Olives";
}
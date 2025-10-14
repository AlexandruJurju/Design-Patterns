using AbstractFactory.Pizza.Products.Ingredients.Abstractions;

namespace AbstractFactory.Pizza.Products.Ingredients;

public class PlumTomatoSauce : ISauce
{
    public string Name => "Plum tomato sauce";
}
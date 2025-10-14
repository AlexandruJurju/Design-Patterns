using AbstractFactory.Pizza.Products.Ingredients.Abstractions;

namespace AbstractFactory.Pizza.Products.Ingredients;

public class MarinaraSauce : ISauce
{
    public string Name => "Marinara Sauce";
}
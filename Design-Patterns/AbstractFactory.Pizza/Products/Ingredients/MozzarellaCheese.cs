using AbstractFactory.Pizza.Products.Ingredients.Abstractions;

namespace AbstractFactory.Pizza.Products.Ingredients;

public class MozzarellaCheese : ICheese
{
    public string Name => "Mozzarella Cheese";
}
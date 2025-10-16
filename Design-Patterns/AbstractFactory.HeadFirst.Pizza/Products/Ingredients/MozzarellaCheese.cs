using AbstractFactory.HeadFirst.Pizza.Products.Ingredients.Abstractions;

namespace AbstractFactory.HeadFirst.Pizza.Products.Ingredients;

public class MozzarellaCheese : ICheese
{
    public string Name => "Mozzarella Cheese";
}
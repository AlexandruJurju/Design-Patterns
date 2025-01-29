using AbstractFactory.Pizza.Products.Ingredients.Abstractions;

namespace AbstractFactory.Pizza.Products.Ingredients;

public class ParmesanCheese : ICheese
{
    public string Name => "Parmesan";
}
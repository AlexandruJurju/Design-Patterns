using AbstractFactory.HeadFirst.Pizza.Products.Ingredients.Abstractions;

namespace AbstractFactory.HeadFirst.Pizza.Products.Ingredients;

public class ParmesanCheese : ICheese
{
    public string Name => "Parmesan";
}
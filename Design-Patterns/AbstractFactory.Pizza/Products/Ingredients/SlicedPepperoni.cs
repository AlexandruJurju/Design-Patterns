using AbstractFactory.Pizza.Products.Ingredients.Abstractions;

namespace AbstractFactory.Pizza.Products.Ingredients;

public class SlicedPepperoni : IPepperoni
{
    public string Name => "Sliced Pepperoni";
}
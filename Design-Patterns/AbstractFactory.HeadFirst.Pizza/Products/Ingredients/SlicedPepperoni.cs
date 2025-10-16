using AbstractFactory.HeadFirst.Pizza.Products.Ingredients.Abstractions;

namespace AbstractFactory.HeadFirst.Pizza.Products.Ingredients;

public class SlicedPepperoni : IPepperoni
{
    public string Name => "Sliced Pepperoni";
}
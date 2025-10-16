using AbstractFactory.HeadFirst.Pizza.Products.Ingredients.Abstractions;

namespace AbstractFactory.HeadFirst.Pizza.AbstractFactories;

public interface IPizzaIngredientFactory
{
    IDough CreateDough();
    ISauce CreateSauce();
    ICheese CreateCheese();
    IVeggies[] CreateVeggies();
    IPepperoni CreatePepperoni();
    IClams CreateClam();
}
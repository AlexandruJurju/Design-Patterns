using AbstractFactory.HeadFirst.Pizza.Products.Ingredients;
using AbstractFactory.HeadFirst.Pizza.Products.Ingredients.Abstractions;

namespace AbstractFactory.HeadFirst.Pizza.AbstractFactories;

public class ChicagoPizzaIngredientFactory : IPizzaIngredientFactory
{
    public ICheese CreateCheese()
    {
        return new MozzarellaCheese();
    }

    public IClams CreateClam()
    {
        return new FrozenClams();
    }

    public IDough CreateDough()
    {
        return new ThickCrustDough();
    }

    public IPepperoni CreatePepperoni()
    {
        return new SlicedPepperoni();
    }

    public ISauce CreateSauce()
    {
        return new PlumTomatoSauce();
    }

    public IVeggies[] CreateVeggies()
    {
        IVeggies[] veggies = { new BlackOlives(), new Spinach(), new Eggplant() };
        return veggies;
    }
}
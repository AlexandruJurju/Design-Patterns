using AbstractFactory.Pizza.AbstractFactories;
using AbstractFactory.Pizza.Products.Pizzas;

namespace AbstractFactory.Pizza.FactoryMethods;

public class ChicagoPizzaStore : PizzaStore
{
    protected override Products.Pizzas.Pizza CreatePizza(string item)
    {
        Products.Pizzas.Pizza pizza = null;
        IPizzaIngredientFactory ingredientFactory = new ChicagoPizzaIngredientFactory();

        switch (item)
        {
            case "cheese":
                pizza = new CheesePizza(ingredientFactory) { Name = "Chicago Style Cheese Pizza" };
                break;
            case "veggie":
                pizza = new VeggiePizza(ingredientFactory) { Name = "Chicago Style Veggie Pizza" };
                break;
            case "clam":
                pizza = new ClamPizza(ingredientFactory) { Name = "Chicago Style Clam Pizza" };
                break;
            case "pepperoni":
                pizza = new PepperoniPizza(ingredientFactory) { Name = "Chicago Style Pepperoni Pizza" };
                break;
        }

        return pizza;
    }
}
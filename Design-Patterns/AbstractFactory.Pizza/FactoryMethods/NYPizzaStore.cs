using AbstractFactory.Pizza.AbstractFactories;
using AbstractFactory.Pizza.Products.Pizzas;

namespace AbstractFactory.Pizza.FactoryMethods;

public class NYPizzaStore : PizzaStore
{
    protected override Products.Pizzas.Pizza CreatePizza(string item)
    {
        Products.Pizzas.Pizza pizza = null;
        IPizzaIngredientFactory ingredientFactory = new NYPizzaIngredientFactory();

        switch (item)
        {
            case "cheese":
                pizza = new CheesePizza(ingredientFactory) { Name = "New York Style Cheese Pizza" };
                break;
            case "veggie":
                pizza = new VeggiePizza(ingredientFactory) { Name = "New York Style Veggie Pizza" };
                break;
            case "clam":
                pizza = new ClamPizza(ingredientFactory) { Name = "New York Style Clam Pizza" };
                break;
            case "pepperoni":
                pizza = new PepperoniPizza(ingredientFactory) { Name = "New York Style Pepperoni Pizza" };
                break;
        }

        return pizza;
    }
}
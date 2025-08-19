using FactoryMethod.Pizza.Products;

namespace FactoryMethod.Pizza.FactoryMethods;

public class NYPizzaStore : PizzaStore
{
    public override Products.Pizza CreatePizza(string name)
    {
        Products.Pizza? pizza = null;
        switch (name)
        {
            case "cheese":
                pizza = new NYStyleCheesePizza();
                break;
            case "veggie":
                pizza = new NYStyleVeggiePizza();
                break;
        }

        return pizza;
    }
}
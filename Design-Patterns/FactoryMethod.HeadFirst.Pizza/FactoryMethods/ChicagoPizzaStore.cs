using FactoryMethod.HeadFirst.Pizza.Products;

namespace FactoryMethod.HeadFirst.Pizza.FactoryMethods;

public class ChicagoPizzaStore : PizzaStore
{
    public override Products.Pizza CreatePizza(string name)
    {
        Products.Pizza pizza = null;

        switch (name)
        {
            case "cheese":
                pizza = new ChicagoStyleCheesePizza();
                break;
            case "veggie":
                pizza = new ChicagoStyleVeggiePizza();
                break;
        }

        return pizza;
    }
}
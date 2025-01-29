

namespace FactoryMethod.Pizza.FactoryMethods;

public abstract class PizzaStore
{
    public abstract Products.Pizza CreatePizza(string name);
    
    public Products.Pizza OrderPizza(string type)
    {
        Products.Pizza pizza = CreatePizza(type);
        Console.WriteLine("--- Making a " + pizza.Name + " ---");
        pizza.Prepare();
        pizza.Bake();
        pizza.Cut();
        pizza.Box();
        return pizza;
    }
}
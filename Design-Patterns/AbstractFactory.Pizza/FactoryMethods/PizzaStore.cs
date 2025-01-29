namespace AbstractFactory.Pizza.FactoryMethods;

public abstract class PizzaStore
{
    protected abstract Products.Pizzas.Pizza CreatePizza(string item);

    public Products.Pizzas.Pizza OrderPizza(string type)
    {
        Products.Pizzas.Pizza pizza = CreatePizza(type);
        Console.WriteLine("--- Making a " + pizza.Name + " ---");
        pizza.Prepare();
        pizza.Bake();
        pizza.Cut();
        pizza.Box();
        return pizza;
    }
}
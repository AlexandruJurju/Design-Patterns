using AbstractFactory.Pizza.FactoryMethods;
using AbstractFactory.Pizza.Products.Pizzas;

PizzaStore nyStore = new NYPizzaStore();
PizzaStore chicagoStore = new ChicagoPizzaStore();

Pizza pizza = nyStore.OrderPizza("cheese");
Console.WriteLine("Ethan ordered a " + pizza + "\n");

Pizza veggiePizza = nyStore.OrderPizza("veggie");
Console.WriteLine("Ethan ordered a " + veggiePizza + "\n");

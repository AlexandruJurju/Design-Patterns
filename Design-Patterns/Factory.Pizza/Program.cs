using Factory.Pizza.FactoryMethods;
using Factory.Pizza.Products;

PizzaStore nyStore = new NYPizzaStore();
PizzaStore chicagoStore = new ChicagoPizzaStore();

Pizza pizza = nyStore.OrderPizza("cheese");
Console.WriteLine("Ethan ordered a " + pizza + "\n");

pizza = chicagoStore.OrderPizza("cheese");
Console.WriteLine("Joel ordered a " + pizza + "\n");

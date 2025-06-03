using AbstractFactory.Pizza.FactoryMethods;

PizzaStore nyStore = new NYPizzaStore();
PizzaStore chicagoStore = new ChicagoPizzaStore();

var pizza = nyStore.OrderPizza("cheese");
Console.WriteLine("Ethan ordered a " + pizza + "\n");

var veggiePizza = nyStore.OrderPizza("veggie");
Console.WriteLine("Ethan ordered a " + veggiePizza + "\n");
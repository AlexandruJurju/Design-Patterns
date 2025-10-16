using AbstractFactory.HeadFirst.Pizza.AbstractFactories;

namespace AbstractFactory.HeadFirst.Pizza.Products.Pizzas;

public class ClamPizza : Pizza
{
    private readonly IPizzaIngredientFactory _ingredientFactory;

    public ClamPizza(IPizzaIngredientFactory ingredientFactory)
    {
        _ingredientFactory = ingredientFactory;
    }

    public override void Prepare()
    {
        Console.WriteLine("Preparing " + Name);
        Dough = _ingredientFactory.CreateDough();
        Sauce = _ingredientFactory.CreateSauce();
        Cheese = _ingredientFactory.CreateCheese();
        Clam = _ingredientFactory.CreateClam();
    }
}
namespace Factory.Pizza.Products;

public class NYStyleCheesePizza : Pizza
{
    public NYStyleCheesePizza()
    {
        Name = "NY Style Sauce and Cheese Pizza";
        Dough = "Thin Crust Dough";
        Sauce = "Marinara Sauce";

        Toppings.Add("Grated Reggiano Cheese");
    }

    public override void Cut()
    {
        Console.WriteLine("Cutting the pizza into triangle slices");
    }
}
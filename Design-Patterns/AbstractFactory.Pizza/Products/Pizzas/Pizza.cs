using System.Text;
using AbstractFactory.Pizza.Products.Ingredients.Abstractions;

namespace AbstractFactory.Pizza.Products.Pizzas;

public abstract class Pizza
{
    public string Name { get; init; }
    public IDough? Dough { get; protected set; }
    public ISauce? Sauce { get; protected set; }
    public IVeggies[]? Veggies { get; protected set; }
    public ICheese? Cheese { get; protected set; }
    public IPepperoni? Pepperoni { get; protected set; }
    public IClams? Clam { get; protected set; }

    public abstract void Prepare();

    public virtual void Bake()
    {
        Console.WriteLine("Bake for 25 minutes at 350");
    }

    public virtual void Cut()
    {
        Console.WriteLine("Cutting the pizza into diagonal slices");
    }

    public virtual void Box()
    {
        Console.WriteLine("Place pizza in official PizzaStore box");
    }

    public override string ToString()
    {
        var result = new StringBuilder();
        result.AppendLine("---- " + Name + " ----");
        if (Dough != null)
        {
            result.AppendLine(Dough.Name);
        }
        if (Sauce != null)
        {
            result.AppendLine(Sauce.Name);
        }
        if (Cheese != null)
        {
            result.AppendLine(Cheese.Name);
        }
        if (Veggies != null)
        {
            for (int i = 0; i < Veggies.Length; i++)
            {
                result.Append(Veggies[i].Name);
                if (i < Veggies.Length - 1)
                {
                    result.Append(", ");
                }
            }
            result.Append("\n");
        }
        if (Clam != null)
        {
            result.AppendLine(Clam.Name);
        }
        if (Pepperoni != null)
        {
            result.AppendLine(Pepperoni.Name);
        }

        return result.ToString();
    }
}
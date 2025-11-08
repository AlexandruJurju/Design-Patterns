namespace Decorator.Dometrain.Tesla;

public class BasicTeslaModel3 : ITeslaModel3
{
    public string GetDescription()
    {
       return "BasicTeslaModel3";
    }

    public decimal GetPrice()
    {
        return 40000;
    }

    public int GetRange()
    {
        return 275;
    }
}
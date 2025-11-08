namespace Decorator.Dometrain.Tesla;

public class RedPaintTeslaDecorator(ITeslaModel3 teslaModel3) : TeslaDecorator(teslaModel3)
{
    public override decimal GetPrice()
    {
        return base.GetPrice() + 2_000;
    }

    public override string GetDescription()
    {
        return _car.GetDescription() + " Red Paint";
    }
}
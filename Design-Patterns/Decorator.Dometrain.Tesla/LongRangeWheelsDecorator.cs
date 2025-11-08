namespace Decorator.Dometrain.Tesla;

public class LongRangeWheelsDecorator(ITeslaModel3 teslaModel3) : TeslaDecorator(teslaModel3)
{
    public override string GetDescription()
    {
        return base.GetDescription() + " Long Range Wheels";
    }

    public override decimal GetPrice()
    {
        return base.GetPrice() + 3_500;
    }
}
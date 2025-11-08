namespace Decorator.Dometrain.Tesla;

public abstract class TeslaDecorator(ITeslaModel3 teslaModel3) : ITeslaModel3
{
    protected ITeslaModel3 _car = teslaModel3;

    public virtual string GetDescription()
    {
        return _car.GetDescription();
    }

    public virtual decimal GetPrice()
    {
        return _car.GetPrice();
    }

    public virtual int GetRange()
    {
        return _car.GetRange();
    }
}
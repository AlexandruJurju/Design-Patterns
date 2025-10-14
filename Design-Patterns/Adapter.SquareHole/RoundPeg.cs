namespace Adapter.SquareHole;

public class RoundPeg : IRoundPeg
{
    public RoundPeg(double radius)
    {
        Radius = radius;
    }

    public double Radius { get; set; }
}
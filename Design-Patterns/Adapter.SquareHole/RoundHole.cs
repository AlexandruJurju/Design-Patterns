namespace Adapter.SquareHole;

internal class RoundHole
{
    private readonly double _radius;

    public RoundHole(double radius)
    {
        _radius = radius;
    }

    public bool Fits(IRoundPeg peg)
    {
        return peg.Radius <= _radius;
    }
}
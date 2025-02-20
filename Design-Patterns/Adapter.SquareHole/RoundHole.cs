namespace Adapter.SquareHole;

class RoundHole
{
    private double _radius;

    public RoundHole(double radius)
    {
        _radius = radius;
    }

    public bool Fits(IRoundPeg peg)
    {
        return peg.Radius <= _radius;
    }
}
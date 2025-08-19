namespace Adapter.SquareHole;

public class SquarePegAdapter : IRoundPeg
{
    private readonly ISquarePeg _squarePeg;

    public SquarePegAdapter(ISquarePeg squarePeg)
    {
        _squarePeg = squarePeg;
    }

    public double Radius => _squarePeg.Width * Math.Sqrt(2) / 2;
}
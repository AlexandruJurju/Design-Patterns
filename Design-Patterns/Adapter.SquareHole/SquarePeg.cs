namespace Adapter.SquareHole;

public class SquarePeg : ISquarePeg
{
    public SquarePeg(int width)
    {
        Width = width;
    }

    public int Width { get; set; }
}
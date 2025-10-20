namespace Adapter.Dometrain.GameEngine;

public class LegacyRectangle(int left, int top, int right, int bottom)
{
    private int _bottom = bottom;
    private int _top = top;

    public int GetArea()
    {
        return (_bottom - _top) * (right - left);
    }

    public int CalculatePerimeter()
    {
        int height = _bottom - _top;
        int width = right - left;

        return 2 * (height + width);
    }

    public void Shift(int horizontal, int vertical)
    {
        _top += vertical;
        _bottom -= vertical;
    }
}
using Bridge.Shapes.Implementation;

namespace Bridge.Shapes.Abstraction;

public abstract class Shape
{
    protected readonly IColor _color;

    protected Shape(IColor color)
    {
        _color = color;
    }

    public abstract void Draw();
}
using Bridge.Shapes.Implementation;

namespace Bridge.Shapes.Abstraction;

public class Square : Shape
{
    public Square(IColor color) : base(color)
    {
    }

    public override void Draw()
    {
        Console.WriteLine($"Drawing a Square with {_color.Fill()}");
    }
}
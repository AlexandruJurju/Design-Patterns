using Bridge.Shapes.Implementation;

namespace Bridge.Shapes.Abstraction;

public class Circle : Shape
{
    public Circle(IColor color) : base(color)
    {
    }

    public override void Draw()
    {
        Console.WriteLine($"Drawing a Circle with {_color.Fill()}");
    }
}
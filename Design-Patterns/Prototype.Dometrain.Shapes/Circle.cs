namespace Prototype.Dometrain.Shapes;

public class Circle(int radius, Color color) : IPrototype<Circle>
{
    public Circle Clone()
    {
        return new Circle(radius, color.Clone());
    }
}
namespace Prototype.Dometrain.Shapes;

public class Rectangle(int width, int height, Color color) : IPrototype<Rectangle>
{
    public Rectangle Clone()
    {
        return new Rectangle(width, height, color);
    }
}
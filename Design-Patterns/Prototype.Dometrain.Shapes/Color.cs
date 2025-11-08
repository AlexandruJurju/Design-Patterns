namespace Prototype.Dometrain.Shapes;

public class Color(ushort red, ushort green, ushort blue ) : IPrototype<Color>
{
    public static Color Gray => new Color(128, 128, 128);

    public Color Clone()
    {
       return new Color(red, green, blue);
    }
}
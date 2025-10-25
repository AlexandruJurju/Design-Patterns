namespace Flyweight.Dometrain.Document;

public class Glyph(char character, string fontFamily) : IGlyph
{
    public void Render(int x, int y, int size, string color)
    {
        // uses both extrinsic and intrinsic data

        Console.WriteLine($"Rendering glyph {character} {x},{y},{size},{color},{fontFamily}");
    }
}
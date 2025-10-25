namespace Flyweight.Dometrain.Document;

public interface IGlyph
{
    void Render(int x, int y, int size, string color);
}
namespace Flyweight.Dometrain.Document;

public class DocumentEditor(GlyphFactory glyphFactory)
{

    private readonly List<(IGlyph glyph, int x, int y, int size, string color)> _characters = new();

    public void InsertCharacter(char character, string fontFamily, int x, int y, int size, string color)
    {
        var glyph = glyphFactory.GetGlyph(character, fontFamily);
        _characters.Add((glyph, x, y, size, color));

    }

    public void Render()
    {
        foreach (var character in _characters)
        {
            character.glyph.Render(character.x, character.y, character.size, character.color);
        }
    }
}
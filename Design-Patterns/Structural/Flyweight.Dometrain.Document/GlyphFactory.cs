namespace Flyweight.Dometrain.Document;

public class GlyphFactory
{
    private readonly Dictionary<(char character, string fontFamily), IGlyph> _glyphs = new();

    public IGlyph GetGlyph(char character, string fontFamily)
    {
        if (!_glyphs.ContainsKey((character, fontFamily)))
        {
            _glyphs[(character, fontFamily)] = new Glyph(character, fontFamily);
        }

        return _glyphs[(character, fontFamily)];
    }
}
using Visitor.DocumentDometrain.Visitors;

namespace Visitor.DocumentDometrain.Elements;

public class SubtitleElement : IDocumentElement
{
    public string Text { get; set; }

    public SubtitleElement(string text)
    {
        Text = text;
    }

    public void Accept(IDocumentVisitor documentVisitor)
    {
        documentVisitor.Visit(this);
    }
}
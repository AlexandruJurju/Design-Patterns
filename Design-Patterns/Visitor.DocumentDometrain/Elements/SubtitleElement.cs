using Visitor.DocumentDometrain.Visitors;

namespace Visitor.DocumentDometrain.Elements;

public class SubtitleElement : IDocumentElement
{
    public SubtitleElement(string text)
    {
        Text = text;
    }

    public string Text { get; set; }

    public void Accept(IDocumentVisitor documentVisitor)
    {
        documentVisitor.Visit(this);
    }
}
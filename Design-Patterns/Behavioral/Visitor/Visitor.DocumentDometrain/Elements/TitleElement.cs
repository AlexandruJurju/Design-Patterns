using Visitor.DocumentDometrain.Visitors;

namespace Visitor.DocumentDometrain.Elements;

public class TitleElement : IDocumentElement
{
    public TitleElement(string text)
    {
        Text = text;
    }

    public string Text { get; set; }

    public void Accept(IDocumentVisitor documentVisitor)
    {
        documentVisitor.Visit(this);
    }
}
using Visitor.DocumentDometrain.Visitors;

namespace Visitor.DocumentDometrain.Elements;

public class TitleElement : IDocumentElement
{
    public string Text { get; set; }

    public TitleElement(string text)
    {
        Text = text;
    }

    public void Accept(IDocumentVisitor documentVisitor)
    {
        documentVisitor.Visit(this);
    }
}
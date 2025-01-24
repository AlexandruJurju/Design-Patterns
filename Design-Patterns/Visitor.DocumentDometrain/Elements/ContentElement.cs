using Visitor.DocumentDometrain.Visitors;

namespace Visitor.DocumentDometrain.Elements;

public class ContentElement : IDocumentElement
{
    public string Text { get; set; }

    public ContentElement(string text)
    {
        Text = text;
    }

    public void Accept(IDocumentVisitor documentVisitor)
    {
        documentVisitor.Visit(this);
    }
}
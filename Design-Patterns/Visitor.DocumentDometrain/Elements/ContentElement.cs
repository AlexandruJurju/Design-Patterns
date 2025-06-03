using Visitor.DocumentDometrain.Visitors;

namespace Visitor.DocumentDometrain.Elements;

public class ContentElement : IDocumentElement
{
    public ContentElement(string text)
    {
        Text = text;
    }

    public string Text { get; set; }

    public void Accept(IDocumentVisitor documentVisitor)
    {
        documentVisitor.Visit(this);
    }
}
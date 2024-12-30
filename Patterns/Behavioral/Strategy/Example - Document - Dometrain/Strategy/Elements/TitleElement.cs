using Strategy.Visitors;

namespace Strategy.Elements;

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
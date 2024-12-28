using Strategy.Visitors;

namespace Strategy.Elements;

public interface IDocumentElement
{
    void Accept(IDocumentVisitor documentVisitor);
}
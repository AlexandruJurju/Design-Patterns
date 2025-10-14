using Visitor.Conceptual.Visitors;

namespace Visitor.Conceptual.Elements;

public interface IElement
{
    void Accept(IVisitor visitor);
}
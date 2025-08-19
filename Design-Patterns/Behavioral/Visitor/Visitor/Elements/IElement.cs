using Visitor.Visitors;

namespace Visitor.Elements;

public interface IElement
{
    void Accept(IVisitor visitor);
}
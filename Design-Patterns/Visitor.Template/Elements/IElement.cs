using Visitor.Template.Visitors;

namespace Visitor.Template.Elements;

public interface IElement
{
    void Accept(IVisitor visitor);
}
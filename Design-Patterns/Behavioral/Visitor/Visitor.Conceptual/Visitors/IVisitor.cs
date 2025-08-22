using Visitor.Conceptual.Elements;

namespace Visitor.Conceptual.Visitors;

public interface IVisitor
{
    void Visit(ConcreteElement1 concreteElement1);
    void Visit(ConcreteElement2 concreteElement2);
}
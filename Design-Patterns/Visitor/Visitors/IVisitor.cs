using Visitor.Elements;

namespace Visitor.Visitors;

public interface IVisitor
{
    void Visit(ConcreteElement1 concreteElement1);
    void Visit(ConcreteElement2 concreteElement2);
}
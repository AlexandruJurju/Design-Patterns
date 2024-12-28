using Strategy.Elements;

namespace Strategy.Visitors;

public interface IVisitor
{
    void Visit(ConcreteElement1 element);
    void Visit(ConcreteElement2 element);
}
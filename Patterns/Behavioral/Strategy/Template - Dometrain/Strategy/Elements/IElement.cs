using Strategy.Visitors;

namespace Strategy.Elements;

public interface IElement
{
    void Accept(IVisitor visitor);
}
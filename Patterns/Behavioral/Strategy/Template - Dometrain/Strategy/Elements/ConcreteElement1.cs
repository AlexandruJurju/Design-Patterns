using Strategy.Visitors;

namespace Strategy.Elements;

public class ConcreteElement1 : IElement
{
    public void Accept(IVisitor visitor)
    {
        visitor.Visit(this);
    }

    public string Operation1()
    {
        return "concrete element 1";
    }
}
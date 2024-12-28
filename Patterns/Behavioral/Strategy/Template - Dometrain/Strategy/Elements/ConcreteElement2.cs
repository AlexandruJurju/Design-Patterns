using Strategy.Visitors;

namespace Strategy.Elements;

public class ConcreteElement2 : IElement
{
    public void Accept(IVisitor visitor)
    {
        visitor.Visit(this);
    }

    public string Operation2()
    {
        return "concrete element 2";
    }
}
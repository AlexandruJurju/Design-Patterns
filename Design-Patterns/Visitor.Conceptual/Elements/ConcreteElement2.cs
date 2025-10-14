using Visitor.Conceptual.Visitors;

namespace Visitor.Conceptual.Elements;

public class ConcreteElement2 : IElement
{
    public void Accept(IVisitor visitor)
    {
        visitor.Visit(this);
    }

    public void Operation2()
    {
        Console.WriteLine("ConcreteElement2");
    }
}
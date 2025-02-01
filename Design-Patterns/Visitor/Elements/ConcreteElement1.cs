using Visitor.Visitors;

namespace Visitor.Elements;

public class ConcreteElement1 : IElement
{
    public void Accept(IVisitor visitor)
    {
        visitor.Visit(this);
    }

    public void Operation1()
    {
        Console.WriteLine("Concrete element 1");
    }
}
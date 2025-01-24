using Visitor.Template.Visitors;

namespace Visitor.Template.Elements;

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
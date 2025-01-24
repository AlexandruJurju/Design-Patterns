using Visitor.Template.Elements;

namespace Visitor.Template.Visitors;

public class ConcreteVisitor2 : IVisitor
{
    public void Visit(ConcreteElement1 concreteElement1)
    {
        Console.WriteLine("ConcreteVisitor2");
        concreteElement1.Operation1();
    }

    public void Visit(ConcreteElement2 concreteElement2)
    {
        Console.WriteLine("ConcreteVisitor2");
        concreteElement2.Operation2();
    }
}
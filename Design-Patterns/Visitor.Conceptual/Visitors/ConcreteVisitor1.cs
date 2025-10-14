using Visitor.Conceptual.Elements;

namespace Visitor.Conceptual.Visitors;

public class ConcreteVisitor1 : IVisitor
{
    public void Visit(ConcreteElement1 concreteElement1)
    {
        Console.WriteLine("ConcreteVisitor1");
        concreteElement1.Operation1();
    }

    public void Visit(ConcreteElement2 concreteElement2)
    {
        Console.WriteLine("ConcreteVisitor1");
        concreteElement2.Operation2();
    }
}
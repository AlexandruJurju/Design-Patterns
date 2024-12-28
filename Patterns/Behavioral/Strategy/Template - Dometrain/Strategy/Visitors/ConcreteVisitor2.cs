using Strategy.Elements;

namespace Strategy.Visitors;

public class ConcreteVisitor2 : IVisitor
{
    public void Visit(ConcreteElement1 element)
    {
        var message = element.Operation1();
        Console.WriteLine($"Concrete Visitor2: {message}");
    }

    public void Visit(ConcreteElement2 element)
    {
        var message = element.Operation2();
        Console.WriteLine($"Concrete Visitor2: {message}");
    }
}
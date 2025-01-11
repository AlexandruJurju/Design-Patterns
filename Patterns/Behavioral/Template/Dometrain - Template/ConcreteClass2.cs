namespace Dometrain_Template;

public class ConcreteClass2 : AbstractClass
{
    protected override void PrimitiveOperation1()
    {
        Console.WriteLine("PrimitiveOperation1 called");
    }

    protected override void PrimitiveOperation2()
    {
        Console.WriteLine("PrimitiveOperation2 called");
    }

    protected override void Hook()
    {
        Console.WriteLine("Hook called in ConcreteClass2");
    }
}
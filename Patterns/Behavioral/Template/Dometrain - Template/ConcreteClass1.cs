namespace Dometrain_Template;

public class ConcreteClass1 : AbstractClass
{
    protected override void PrimitiveOperation1()
    {
        Console.WriteLine("PrimitiveOperation1 invoked");
    }

    protected override void PrimitiveOperation2()
    {
        Console.WriteLine("PrimitiveOperation2 invoked");
    }
}
namespace Template.Conceptual;

public class ConcreteAlgorithmA : Template
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
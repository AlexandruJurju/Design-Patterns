namespace Template.Conceptual;

public abstract class Template
{
    public void TemplateMethod()
    {
        Console.WriteLine("Before operation1");
        PrimitiveOperation1();

        Console.WriteLine("Before operation2");
        PrimitiveOperation2();

        Console.WriteLine("Before hook");
        Hook();
    }

    protected abstract void PrimitiveOperation1();
    protected abstract void PrimitiveOperation2();

    protected virtual void Hook()
    {
        Console.WriteLine("Hook invoked");
    }
}
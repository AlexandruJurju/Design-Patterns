namespace Proxy.Dometrain.Conceptual;

public class RealSubject : ISubject
{
    public RealSubject()
    {
        Console.WriteLine("RealSubject constructor");
    }

    public void Operation()
    {
        Console.WriteLine("Operation in RealSubject");
    }
}
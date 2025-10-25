namespace Proxy.Dometrain.Conceptual;

public class Proxy : ISubject
{
    private  RealSubject? _realSubject = null;

    public Proxy()
    {
        Console.WriteLine("Proxy constructor");
    }

    public void Operation()
    {
        Console.WriteLine("Operation in Proxy");

        if (_realSubject is null)
        {
            _realSubject = new RealSubject();
        }

        Console.WriteLine("Logging before operation");
        _realSubject.Operation();
        Console.WriteLine("Logging after operation");
    }
}
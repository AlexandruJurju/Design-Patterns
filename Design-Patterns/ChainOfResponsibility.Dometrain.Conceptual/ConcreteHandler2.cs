namespace ChainOfResponsibility.Dometrain.Conceptual;

public class ConcreteHandler2 : Handler
{
    public override void Handle(string request)
    {
        if (request == "2")
        {
            Console.WriteLine($"Handler2 handled request {request}");
            return;
        }

        _successor?.Handle(request);
    }
}
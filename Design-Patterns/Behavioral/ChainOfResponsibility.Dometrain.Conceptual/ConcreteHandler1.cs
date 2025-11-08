namespace ChainOfResponsibility.Dometrain.Conceptual;

public class ConcreteHandler1 : Handler
{
    public override void Handle(string request)
    {
        if (request == "1")
        {
            Console.WriteLine($"Handler1 handled request {request}");
            return;
        }

        _successor?.Handle(request);
    }
}
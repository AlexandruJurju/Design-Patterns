namespace ChainOfResponsibility.Dometrain.Conceptual;

public class ConcreteHandler3 : Handler
{
    public override void Handle(string request)
    {
        if (request == "3")
        {
            Console.WriteLine($"Handler3 handled request {request}");
            return;
        }

        _successor?.Handle(request);
    }
}
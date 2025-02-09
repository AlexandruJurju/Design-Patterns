namespace ChainOfResponsibility.RequestHandler;

public class ValidationHandler : BaseRequestHandler
{
    protected override void ProcessRequest(Request request)
    {
        Console.WriteLine("Validation handler processing request");
        if (string.IsNullOrEmpty(request.Content))
        {
            request.IsValid = false;
            Console.WriteLine("Validation failed: Request content is empty.");
            return;
        }

        Console.WriteLine("Validation successful: Request content is valid.");
    }
}
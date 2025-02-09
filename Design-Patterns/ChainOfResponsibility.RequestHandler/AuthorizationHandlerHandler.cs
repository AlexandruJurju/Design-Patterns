namespace ChainOfResponsibility.RequestHandler;

public class AuthorizationHandler : BaseRequestHandler
{
    protected override void ProcessRequest(Request request)
    {
        Console.WriteLine("Authorization handler processing request");
        if (!request.Content.Contains("ADMIN"))
        {
            request.IsValid = false;
            Console.WriteLine("Authorization failed: User is not authorized.");
            return;
        }
        Console.WriteLine("Authorization successful: User is an ADMIN.");
    }
}

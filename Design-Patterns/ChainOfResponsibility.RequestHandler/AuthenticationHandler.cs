namespace ChainOfResponsibility.RequestHandler;

public class AuthenticationHandler : BaseRequestHandler
{
    protected override void ProcessRequest(Request request)
    {
        Console.WriteLine("Authentication handler processing request");
        if (!request.Content.Contains("JWT"))
        {
            request.IsValid = false;
            Console.WriteLine("Authentication failed: Invalid token.");
            return;
        }

        Console.WriteLine("Authentication successful.");
    }
}
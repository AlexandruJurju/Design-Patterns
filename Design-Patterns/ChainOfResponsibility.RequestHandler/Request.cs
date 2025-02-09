namespace ChainOfResponsibility.RequestHandler;

public class Request
{
    public string Content { get; set; }
    public bool IsValid { get; set; } = true;
}
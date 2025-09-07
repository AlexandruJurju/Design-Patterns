namespace ChainOfResponsibility.Iluwatar.OrcKing.Handlers;

public class OrcCommander : IRequestHandler
{
    public int Priority => 2;

    public string Name => "Orc Commander";

    public bool CanHandleRequest(Request request)
    {
        return request.RequestType == RequestType.DefendCastle;
    }

    public void HandleRequest(Request request)
    {
        request.Handled = true;
        Console.WriteLine($"{Name} handles request: {request.Description}");
    }
}
namespace ChainOfResponsibility.Iluwatar.OrcKing.Handlers;

public class OrcOfficer : IRequestHandler
{
    public int Priority => 3;
    public string Name => "Orc OrcOfficer";

    public bool CanHandleRequest(Request request)
    {
        return request.RequestType == RequestType.TorturePrisoner;
    }

    public void HandleRequest(Request request)
    {
        Console.WriteLine($"{Name} handles request: {request.Description}");
    }
}
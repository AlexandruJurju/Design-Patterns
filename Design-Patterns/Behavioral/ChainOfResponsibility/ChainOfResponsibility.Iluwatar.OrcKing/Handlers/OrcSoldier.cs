namespace ChainOfResponsibility.Iluwatar.OrcKing.Handlers;

public class OrcSoldier : IRequestHandler
{
    public int Priority => 1;
    public string Name => "Orc Soldier";

    public bool CanHandleRequest(Request request)
    {
        return request.RequestType == RequestType.CollectTaxes;
    }

    public void HandleRequest(Request request)
    {
        Console.WriteLine($"{Name} handles request: {request.Description}");
    }
}
using ChainOfResponsibility.Iluwatar.OrcKing.Handlers;

namespace ChainOfResponsibility.Iluwatar.OrcKing;

public class OrcKing
{
    private List<IRequestHandler> _handlers = new();

    public OrcKing()
    {
        BuildChain();
    }

    private void BuildChain()
    {
        _handlers = [new OrcCommander(), new OrcOfficer(), new OrcSoldier()];
    }

    public void MakeRequest(Request request)
    {
        _handlers
            .OrderBy(handler => handler.Priority)
            .FirstOrDefault(handler => handler.CanHandleRequest(request))?.HandleRequest(request);
    }
}
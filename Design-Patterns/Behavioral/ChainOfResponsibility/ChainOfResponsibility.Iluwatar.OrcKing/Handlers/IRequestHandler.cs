namespace ChainOfResponsibility.Iluwatar.OrcKing.Handlers;

public interface IRequestHandler
{
    int Priority { get; }
    string Name { get; }
    bool CanHandleRequest(Request request);
    void HandleRequest(Request request);
}
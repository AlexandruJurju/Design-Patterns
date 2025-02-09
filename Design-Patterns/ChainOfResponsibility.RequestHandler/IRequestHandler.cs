namespace ChainOfResponsibility.RequestHandler;

public interface IRequestHandler
{
    IRequestHandler SetNextHandler(IRequestHandler handler);
    void HandleRequest(Request request);
}
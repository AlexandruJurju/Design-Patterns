namespace ChainOfResponsibility.RequestHandler;

public abstract class BaseRequestHandler : IRequestHandler
{
    private IRequestHandler? _nextHandler;

    public IRequestHandler SetNextHandler(IRequestHandler handler)
    {
        _nextHandler = handler;
        return handler;
    }

    public virtual void HandleRequest(Request request)
    {
        ProcessRequest(request);

        if (request.IsValid && _nextHandler != null)
        {
            _nextHandler.HandleRequest(request);
        }
    }

    protected abstract void ProcessRequest(Request request);
}
namespace ChainOfResponsibility.Conceptual;

public class AbstractHandler : IHandler
{
    private IHandler? _nextHandler;

    public IHandler SetNext(IHandler handler)
    {
        _nextHandler = handler;
        return handler;
    }

    public virtual object? Handle(object request)
    {
        if (_nextHandler is not null)
        {
            return _nextHandler.Handle(request);
        }

        return null;
    }
}
namespace ChainOfResponsibility.Authentication.Handlers;

public abstract class BaseHandler : IHandler
{
    private IHandler? _next;

    public IHandler SetNext(IHandler handler)
    {
        _next = handler;
        return handler;
    }
    
    protected bool HandleNext(User user)
    {
        if (_next is null)
        {
            return true;
        }

        return _next.Handle(user);
    }
    
    public abstract bool Handle(User user);
}
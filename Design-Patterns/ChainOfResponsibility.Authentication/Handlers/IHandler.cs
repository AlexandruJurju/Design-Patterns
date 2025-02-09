namespace ChainOfResponsibility.Authentication.Handlers;

public interface IHandler
{
    IHandler SetNext(IHandler next);
    bool Handle(User user);
}
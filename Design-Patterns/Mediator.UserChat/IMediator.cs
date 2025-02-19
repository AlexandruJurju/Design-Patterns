namespace Mediator.UserChat;

public interface IMediator
{
    public void SendMessage(string message, int chatId);

    public void RegisterChatUser(IUser user);
}
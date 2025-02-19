namespace Mediator.UserChat;

public interface IUser
{
    int ChatId { get; }

    void SendMessage(string message);

    void ReceiveMessage(string message);
}
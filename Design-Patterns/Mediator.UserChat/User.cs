namespace Mediator.UserChat;

public class User(IMediator mediator, string userName, int chatId) : IUser
{
    public string UserName { get; set; } = userName;
    public int ChatId { get; set; } = chatId;

    public void SendMessage(string message)
    {
        Console.WriteLine($"{UserName} sending message: {message}");
        mediator.SendMessage(message, ChatId);
    }

    public void ReceiveMessage(string message)
    {
        Console.WriteLine($"{UserName} received message: {message}");
    }
}
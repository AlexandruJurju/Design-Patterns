namespace Mediator.UserChat;

public class User : IUser
{
    private readonly IMediator _mediator;
    public string UserName { get; set; }
    public int ChatId { get; set; }

    public User(IMediator mediator, string userName, int chatId)
    {
        _mediator = mediator;
        UserName = userName;
        ChatId = chatId;
    }

    public void SendMessage(string message)
    {
        Console.WriteLine($"{UserName} sending message: {message}");
        _mediator.SendMessage(message, ChatId);
    }

    public void ReceiveMessage(string message)
    {
        Console.WriteLine($"{UserName} received message: {message}");
    }
}
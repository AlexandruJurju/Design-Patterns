﻿namespace Mediator.UserChat;

public class ChatMediator : IMediator
{
    private readonly Dictionary<int, IUser> _users;

    public ChatMediator()
    {
        _users = new Dictionary<int, IUser>();
    }

    public void RegisterChatUser(IUser user)
    {
        _users.TryAdd(user.ChatId, user);
    }

    public void SendMessage(string message, int chatId)
    {
        foreach (var user in _users.Where(x => x.Key != chatId))
        {
            user.Value.ReceiveMessage(message);
        }
    }
}
namespace ChainOfResponsibility.Authentication.Handlers;

public class RoleCheckHandler : BaseHandler
{
    public override bool Handle(User user)
    {
        Console.WriteLine($"Checking if user {user.Username} is an admin");
        if (user.Username != "admin")
        {
            Console.WriteLine($"User {user.Username} is not an admin");
            return false;
        }

        Console.WriteLine($"User {user.Username} is an admin");
        return HandleNext(user);
    }
}
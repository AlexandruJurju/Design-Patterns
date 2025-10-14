namespace ChainOfResponsibility.Authentication.Handlers;

public class UserExistsHandler(Database database) : BaseHandler
{
    public override bool Handle(User user)
    {
        Console.WriteLine($"Checking if user {user.Username} exists");

        if (!database.IsValidUser(user.Username))
        {
            Console.WriteLine($"User {user.Username} does not exist");
            return false;
        }

        Console.WriteLine($"User {user.Username} exists");
        return HandleNext(user);
    }
}
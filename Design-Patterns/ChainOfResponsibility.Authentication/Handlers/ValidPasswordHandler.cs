namespace ChainOfResponsibility.Authentication.Handlers;

public class ValidPasswordHandler(Database database) : BaseHandler
{
    public override bool Handle(User user)
    {
        Console.WriteLine($"Checking if user {user.Username} has the correct password");

        if (!database.IsValidPassword(user.Username, user.Password))
        {
            Console.WriteLine("Invalid password");
            return false;
        }

        Console.WriteLine($"User {user.Username} has the correct password");
        return HandleNext(user);
    }
}
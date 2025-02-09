namespace ChainOfResponsibility.Authentication.Handlers;

public class UserExistsHandler : BaseHandler
{
    private readonly Database database;

    public UserExistsHandler(Database database)
    {
        this.database = database;
    }

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
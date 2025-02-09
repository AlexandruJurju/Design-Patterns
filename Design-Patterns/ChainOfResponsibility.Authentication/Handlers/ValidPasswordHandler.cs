namespace ChainOfResponsibility.Authentication.Handlers;

public class ValidPasswordHandler : BaseHandler
{
    private readonly Database _database;

    public ValidPasswordHandler(Database database)
    {
        _database = database;
    }

    public override bool Handle(User user)
    {
        Console.WriteLine($"Checking if user {user.Username} has the correct password");
        if (!_database.IsValidPassword(user.Username, user.Password))
        {
            Console.WriteLine("Invalid password");
            return false;
        }

        Console.WriteLine($"User {user.Username} has the correct password");
        return HandleNext(user);
    }
}
namespace SimpleFactory.Dometrain;

public class User
{
    public Guid Id { get; init; }
    public string Username { get; init; }
    public string PasswordHash { get; init; }

    private User(string username, string password)
    {
        Username = username;
        PasswordHash = password;
    }

    public static User CreateUser(string username, string password)
    {
        ArgumentNullException.ThrowIfNull(username);
        ArgumentNullException.ThrowIfNull(password);

        // should call hashing
        var passwordHash = password;

        return new User(username, passwordHash);
    }
}
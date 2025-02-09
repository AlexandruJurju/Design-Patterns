namespace ChainOfResponsibility.Authentication;

public class Database
{
    private readonly List<User> _users;

    public Database()
    {
        _users = new List<User>();
        _users.Add(new User
        {
            Username = "admin",
            Password = "admin"
        });
    }

    public bool IsValidUser(string username)
    {
        return _users.Any(u => u.Username == username);
    }

    public bool IsValidPassword(string username, string password)
    {
        var user = _users.FirstOrDefault(u => u.Username == username);
        if (user == null) return false;

        return user.Password == password;
    }
}
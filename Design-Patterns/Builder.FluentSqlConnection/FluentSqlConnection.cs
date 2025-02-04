using System.Data;
using Microsoft.Data.SqlClient;

namespace Builder.FluentSqlConnection;

public class FluentSqlConnection :
    IServerSelectionStage,
    IDatabaseSelectionStage,
    IUsernameSelectionStage,
    IPasswordSelectionStage,
    IConnectionInit
{
    private string _server;
    private string _database;
    private string _username;
    private string _password;

    private FluentSqlConnection()
    {
    }

    public static IServerSelectionStage CreateConnection(
        Action<ConnectionConfiguration> config
    )
    {
        var configuration = new ConnectionConfiguration();
        config?.Invoke(configuration);

        Console.WriteLine(configuration.ConnectionName);
        return new FluentSqlConnection();
    }

    public IDatabaseSelectionStage ForServer(string server)
    {
        _server = server;
        return this;
    }

    public IUsernameSelectionStage ForDatabase(string database)
    {
        _username = database;
        return this;
    }

    public IPasswordSelectionStage AndUsername(string username)
    {
        _username = username;
        return this;
    }

    public IConnectionInit AndPassword(string password)
    {
        _password = password;
        return this;
    }

    public IDbConnection Connect()
    {
        var connection = new SqlConnection($"Server={_server};Database={_database};User Id={_username};Password={_password}");
        return connection;
    }
}

public class ConnectionConfiguration
{
    public string ConnectionName { get; set; }
}

public interface IServerSelectionStage
{
    public IDatabaseSelectionStage ForServer(string server);
}

public interface IDatabaseSelectionStage
{
    public IUsernameSelectionStage ForDatabase(string database);
}

public interface IUsernameSelectionStage
{
    public IPasswordSelectionStage AndUsername(string username);
}

public interface IPasswordSelectionStage
{
    public IConnectionInit AndPassword(string password);
}

public interface IConnectionInit
{
    public IDbConnection Connect();
}
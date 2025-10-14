using System.Data;
using Microsoft.Data.SqlClient;

namespace StepBuilder.SqlConnection;

public class FluentSqlConnection :
    IServerSelectionStage,
    IDatabaseSelectionStage,
    IUsernameSelectionStage,
    IPasswordSelectionStage,
    IConnectionInit
{
    private string _database;
    private string _password;
    private string _server;
    private string _username;

    private FluentSqlConnection()
    {
    }

    public IDbConnection Connect()
    {
        var connection = new Microsoft.Data.SqlClient.SqlConnection($"Server={_server};Database={_database};User Id={_username};Password={_password}");
        return connection;
    }

    public IUsernameSelectionStage ForDatabase(string database)
    {
        _username = database;
        return this;
    }

    public IConnectionInit AndPassword(string password)
    {
        _password = password;
        return this;
    }

    public IDatabaseSelectionStage ForServer(string server)
    {
        _server = server;
        return this;
    }

    public IPasswordSelectionStage AndUsername(string username)
    {
        _username = username;
        return this;
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
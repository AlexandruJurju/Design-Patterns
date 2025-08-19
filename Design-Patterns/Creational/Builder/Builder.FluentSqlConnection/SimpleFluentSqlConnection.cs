using Microsoft.Data.SqlClient;

namespace Builder.FluentSqlConnection;

public class SimpleFluentSqlConnection
{
    private string _database;
    private string _password;
    private string _server;
    private string _username;

    public SimpleFluentSqlConnection ForServer(string server)
    {
        _server = server;
        return this;
    }

    public SimpleFluentSqlConnection ForDatabase(string database)
    {
        _database = database;
        return this;
    }

    public SimpleFluentSqlConnection AsUser(string username)
    {
        _username = username;
        return this;
    }

    public SimpleFluentSqlConnection WithPassword(string password)
    {
        _password = password;
        return this;
    }

    public SqlConnection Connect()
    {
        var connection = new SqlConnection($"Server={_server};Database={_database};User Id={_username};Password={_password}");
        return connection;
    }
}
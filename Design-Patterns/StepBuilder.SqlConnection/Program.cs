using StepBuilder.SqlConnection;

var connection1 = new SimpleFluentSqlConnection()
    .ForServer("localhost")
    .AsUser("alex")
    .WithPassword("password")
    .Connect();

var connection2 = FluentSqlConnection
    .CreateConnection(config => { config.ConnectionName = "FluentSqlConnection"; })
    .ForServer("localhost")
    .ForDatabase("master")
    .AndUsername("admin")
    .AndPassword("password")
    .Connect();
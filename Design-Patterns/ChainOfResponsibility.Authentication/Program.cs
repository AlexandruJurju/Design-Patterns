using ChainOfResponsibility.Authentication;
using ChainOfResponsibility.Authentication.Handlers;

Database database = new Database();

var userExistsHandler = new UserExistsHandler(database);
var validPasswordHandler = new ValidPasswordHandler(database);
var roleCheckHandler = new RoleCheckHandler(database);


userExistsHandler
    .SetNext(validPasswordHandler)
    .SetNext(roleCheckHandler);


userExistsHandler.Handle(new User
{
    Username = "admin",
    Password = "admin"
});
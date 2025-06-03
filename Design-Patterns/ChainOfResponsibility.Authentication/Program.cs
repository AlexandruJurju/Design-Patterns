using ChainOfResponsibility.Authentication;
using ChainOfResponsibility.Authentication.Handlers;

var database = new Database();

var userExistsHandler = new UserExistsHandler(database);
var validPasswordHandler = new ValidPasswordHandler(database);
var roleCheckHandler = new RoleCheckHandler();


userExistsHandler
    .SetNext(validPasswordHandler)
    .SetNext(roleCheckHandler);


userExistsHandler.Handle(new User
{
    Username = "admin",
    Password = "admin"
});
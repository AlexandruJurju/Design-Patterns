using ChainOfResponsibility.RequestHandler;

var authenticationHandler = new AuthenticationHandler();
var authorizationHandler = new AuthorizationHandler();
var validationHandler = new ValidationHandler();

authenticationHandler
    .SetNextHandler(authorizationHandler)
    .SetNextHandler(validationHandler);

var validRequest = new Request { Content = "JWT | ADMIN" };
var invalidTokenRequest = new Request { Content = "INVALID_TOKEN | ADMIN" };
var unauthorizedRequest = new Request { Content = "JWT | USER" };
var emptyRequest = new Request { Content = "" };

Console.WriteLine("Processing valid request:");
authenticationHandler.HandleRequest(validRequest);

Console.WriteLine("\nProcessing request with invalid token:");
authenticationHandler.HandleRequest(invalidTokenRequest);

Console.WriteLine("\nProcessing unauthorized request:");
authenticationHandler.HandleRequest(unauthorizedRequest);

Console.WriteLine("\nProcessing empty request:");
authenticationHandler.HandleRequest(emptyRequest);
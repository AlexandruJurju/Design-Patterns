using Proxy.Conceptual;

var service = new ExpensiveService();
service.Request();
Console.WriteLine();

var proxy = new Proxy.Conceptual.Proxy(service);
proxy.Request();
using Proxy;

ExpensiveService service = new ExpensiveService();
service.Request();
Console.WriteLine();

Proxy.Proxy proxy = new Proxy.Proxy(service);
proxy.Request();

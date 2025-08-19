using Proxy;

var service = new ExpensiveService();
service.Request();
Console.WriteLine();

var proxy = new Proxy.Proxy(service);
proxy.Request();
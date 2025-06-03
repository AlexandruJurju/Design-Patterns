using Adapter;

var adaptee = new Adaptee();
ITarget target = new Adapter.Adapter(adaptee);
Console.WriteLine(target.GetRequest());
using Adapter.Conceptual;

var adaptee = new Adaptee();
ITarget target = new Adapter.Conceptual.Adapter(adaptee);
Console.WriteLine(target.GetRequest());
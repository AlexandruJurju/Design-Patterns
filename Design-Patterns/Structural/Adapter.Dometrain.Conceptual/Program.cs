using Adapter.Dometrain.Conceptual;

ITarget target = new Adapter.Dometrain.Conceptual.Adapter(new Adaptee());

target.Request();
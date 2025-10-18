// See https://aka.ms/new-console-template for more information

using Prototype.Dometrain.Conceptual;

IPrototype prototype1 = new ConcretePrototype1();
IPrototype prototype2 = new ConcretePrototype2();

var prototypeClone = prototype1.Clone();
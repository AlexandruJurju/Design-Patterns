using State.Conceptual;
using State.Conceptual.States;

var context = new Context(new ConcreteStateA());

context.Request(); // state A
context.Request(); // state B
context.Request(); // state A
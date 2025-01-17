using State.Template;
using State.Template.States;

var context = new Context(new ConcreteStateA());

context.Request(); // state A
context.Request(); // state B
context.Request(); // state A
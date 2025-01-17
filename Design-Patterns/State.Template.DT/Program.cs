using State.Template.DT;
using State.Template.DT.States;

Context context = new Context(new ConcreteStateA());

context.Request(); // state A
context.Request(); // state B
context.Request(); // state A
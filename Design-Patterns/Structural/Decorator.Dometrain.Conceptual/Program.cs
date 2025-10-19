using Decorator.Dometrain.Conceptual;
using Decorator.Dometrain.Conceptual.Decorators;

IComponent component = new ConcreteDecorator2(new ConcreteDecorator1(new ConcreteComponent()));

component.Operation();
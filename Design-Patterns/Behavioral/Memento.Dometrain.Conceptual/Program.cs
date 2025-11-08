
using Memento.Dometrain.Conceptual;

Originator originator = new Originator();
Caretaker caretaker = new Caretaker();

originator.SetState("State1");
caretaker.AddMemento(originator.CreateMemento());
originator.SetState("State2");
caretaker.AddMemento(originator.CreateMemento());
originator.SetState("State3");
caretaker.AddMemento(originator.CreateMemento());
originator.SetState("State4");
caretaker.AddMemento(originator.CreateMemento());

Console.WriteLine(originator.GetState());
originator.RestoreMemento(caretaker.GetMemento(0));
Console.WriteLine(originator.GetState());
originator.RestoreMemento(caretaker.GetMemento(2));
Console.WriteLine(originator.GetState());

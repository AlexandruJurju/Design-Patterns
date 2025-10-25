using Observer.Dometrain.Conceptual;

ConcreteSubject subject = new();

subject.Attach(new ConcreteObserver(subject));
subject.Attach(new ConcreteObserver(subject));
subject.Attach(new ConcreteObserver(subject));

subject.State = "NEW";
subject.State = "UPDATE";


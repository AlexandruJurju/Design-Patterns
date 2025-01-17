using Observer.Template;

var subject = new ConcreteSubject();
IObserver observerA = new ConcreteObserverA();
IObserver observerB = new ConcreteObserverB();
subject.Attach(observerA);
subject.Attach(observerB);


subject.ChangeState();
subject.ChangeState();
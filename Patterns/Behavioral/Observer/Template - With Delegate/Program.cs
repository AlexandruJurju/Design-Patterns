using Observer.Observer;
using Observer.Subject;

ConcreteSubject concreteSubject = new ConcreteSubject();

ConcreteObserverA concreteObserverA = new ConcreteObserverA(concreteSubject);
ConcreteObserverB concreteObserverB = new ConcreteObserverB(concreteSubject);

concreteSubject.ChangeState();
concreteSubject.ChangeState();
concreteSubject.ChangeState();
concreteSubject.ChangeState();
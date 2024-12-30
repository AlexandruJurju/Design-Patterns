using Observer.Subject;

namespace Observer.Observer;

public class ConcreteObserverA
{
    public ConcreteObserverA(ConcreteSubject subject)
    {
        subject.ValueChangedEvent += Update;
    }

    public void Update(int number)
    {
        Console.WriteLine($"ConcreteObserverA notified with {number}");
    }
}
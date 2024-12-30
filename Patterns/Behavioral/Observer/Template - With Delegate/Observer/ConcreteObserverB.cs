using Observer.Subject;

namespace Observer.Observer;

public class ConcreteObserverB
{
    public ConcreteObserverB(ConcreteSubject subject)
    {
        subject.ValueChangedEvent += Update;
    }
    
    public void Update(int number)
    {
        Console.WriteLine($"ConcreteObserverB notified with {number}");
    }
}
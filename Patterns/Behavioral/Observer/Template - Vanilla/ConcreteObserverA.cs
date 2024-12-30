namespace Observer;

public class ConcreteObserverA : IObserver
{
    public void Update(int number)
    {
        Console.WriteLine($"ConcreteObserverB notified with {number}");
    }
}
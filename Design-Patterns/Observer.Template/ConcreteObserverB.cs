namespace Observer.Template;

public class ConcreteObserverB : IObserver
{
    public void Update(int number)
    {
        Console.WriteLine($"ConcreteObserverB notified with {number}");
    }
}
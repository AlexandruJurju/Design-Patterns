namespace Observer.Dometrain.Conceptual;

public class ConcreteObserver(ConcreteSubject subject) : IObserver
{
    public void Update()
    {
        var state = subject.State;
        Console.WriteLine($"Observer reacted to state: {state}");
    }
}
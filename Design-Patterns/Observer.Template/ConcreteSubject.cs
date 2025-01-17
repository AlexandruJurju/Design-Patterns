namespace Observer.Template;

public class ConcreteSubject : ISubject
{
    private readonly List<IObserver> _observers = new();
    public int State { get; set; }

    public void Attach(IObserver observer)
    {
        _observers.Add(observer);
    }

    public void Detach(IObserver observer)
    {
        _observers.Remove(observer);
    }

    public void Notify()
    {
        foreach (var observer in _observers)
        {
            observer.Update(State);
        }
    }

    public void ChangeState()
    {
        State = new Random().Next(0, 100);
        Notify();
    }
}
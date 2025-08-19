using Observer.Weather.Observers;

namespace Observer.Weather.Subject;

public interface ISubject
{
    void RegisterObserver(IObserver observer);
    void RemoveObserver(IObserver observer);
    void NotifyObservers();
}
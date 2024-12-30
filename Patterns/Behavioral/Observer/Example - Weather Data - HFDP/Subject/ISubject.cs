using Observer.Observers;

namespace Observer.Subject;

public interface ISubject
{
    void registerObserver(IObserver observer);
    void removeObserver(IObserver observer);
    void notifyObservers();
}
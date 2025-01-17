using Observer.WeatherData.Observers;

namespace Observer.WeatherData.Subject;

public interface ISubject
{
    void RegisterObserver(IObserver observer);
    void RemoveObserver(IObserver observer);
    void NotifyObservers();
}
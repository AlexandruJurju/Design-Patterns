using Observer.WeatherEvents.Observers;

namespace Observer.WeatherEvents.Subject;

public interface ISubject
{
    event EventHandler<WeatherDataEventArgs> WeatherDataChanged;
}
using Observer.WeatherEvents.Subject;

namespace Observer.WeatherEvents.Observers;

public interface IObserver
{
    void Update(object sender, WeatherDataEventArgs e);
}
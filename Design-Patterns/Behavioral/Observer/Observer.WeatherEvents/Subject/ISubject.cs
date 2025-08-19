namespace Observer.WeatherEvents.Subject;

public interface ISubject
{
    event EventHandler<WeatherDataEventArgs> WeatherDataChanged;
}
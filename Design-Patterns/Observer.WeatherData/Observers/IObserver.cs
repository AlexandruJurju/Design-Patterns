namespace Observer.WeatherData.Observers;

public interface IObserver
{
    void Update(double temperature, double humidity, double pressure);
}
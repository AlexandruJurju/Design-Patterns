using Observer.WeatherEvents.Observers;

namespace Observer.WeatherEvents.Subject;

public class WeatherStation : ISubject
{
    public double Temperature { get; set; }
    public double Humidity { get; set; }
    public double Pressure { get; set; }

    public event EventHandler<WeatherDataEventArgs>? WeatherDataChanged;

    protected virtual void OnWeatherDataChanged(WeatherDataEventArgs e)
    {
        WeatherDataChanged?.Invoke(this, e);
    }

    private void MeasurementsChanged()
    {
        var args = new WeatherDataEventArgs(Temperature, Humidity, Pressure);
        OnWeatherDataChanged(args);
    }

    public void SetMeasurements(double temperature, double humidity, double pressure)
    {
        Temperature = temperature;
        Humidity = humidity;
        Pressure = pressure;
        MeasurementsChanged();
    }
}
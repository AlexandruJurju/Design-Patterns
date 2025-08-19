namespace Observer.WeatherEvents.Subject;

public class WeatherDataEventArgs : EventArgs
{
    public WeatherDataEventArgs(double temperature, double humidity, double pressure)
    {
        Temperature = temperature;
        Humidity = humidity;
        Pressure = pressure;
    }

    public double Temperature { get; }
    public double Humidity { get; }
    public double Pressure { get; }
}
using Observer.WeatherData.Subject;

namespace Observer.WeatherData.Observers;

public class CurrentConditionsDisplay : IObserver, IDisplayElement
{
    public CurrentConditionsDisplay(ISubject weatherData)
    {
        weatherData.RegisterObserver(this);
    }

    public double Temperature { get; set; }
    public double Humidity { get; set; }

    public void Display()
    {
        Console.WriteLine($"Current Conditions Display: {Temperature} degrees and {Humidity} % humidity");
    }

    public void Update(double temperature, double humidity, double pressure)
    {
        Temperature = temperature;
        Humidity = humidity;
        Display();
    }
}
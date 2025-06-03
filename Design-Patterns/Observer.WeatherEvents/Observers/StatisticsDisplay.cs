using Observer.WeatherEvents.Subject;

namespace Observer.WeatherEvents.Observers;

public class StatisticsDisplay : IObserver, IDisplayElement
{
    public StatisticsDisplay(ISubject subject)
    {
        subject.WeatherDataChanged += Update;
    }

    public double Temperature { get; set; }
    public double Humidity { get; set; }
    public double Pressure { get; set; }

    public void Display()
    {
        Console.WriteLine($"StatisticsDisplay: {Temperature}, {Humidity}, {Pressure}");
    }

    public void Update(object sender, WeatherDataEventArgs e)
    {
        Temperature = e.Temperature;
        Humidity = e.Humidity;
        Pressure = e.Pressure;
        Display();
    }
}
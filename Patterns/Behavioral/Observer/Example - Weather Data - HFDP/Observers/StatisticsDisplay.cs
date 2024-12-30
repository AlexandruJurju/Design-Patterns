using Observer.Subject;

namespace Observer.Observers;

public class StatisticsDisplay : IObserver, IDisplayElement
{
    public double Temperature { get; set; }
    public double Humidity { get; set; }
    public double Pressure { get; set; }

    public StatisticsDisplay(ISubject subject)
    {
        subject.registerObserver(this);
    }

    public void Update(double temperature, double humidity, double pressure)
    {
        Temperature = temperature;
        Humidity = humidity;
        Pressure = pressure;
        Display();
    }

    public void Display()
    {
        Console.WriteLine($"StatisticsDisplay: {Temperature}, {Humidity}, {Pressure}");
    }
}
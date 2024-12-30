using Observer.Subject;

namespace Observer.Observers;

public class CurrentConditionsDisplay : IObserver, IDisplayElement
{
    public double Temperature { get; set; }
    public double Humidity { get; set; }

    public CurrentConditionsDisplay(ISubject weatherData)
    {
        weatherData.registerObserver(this);
    }
    
    public void Update(double temperature, double humidity, double pressure)
    {
        Temperature = temperature;
        Humidity = humidity;
        Display();
    }

    public void Display()
    {
        Console.WriteLine($"Current Conditions Display: {Temperature} degrees and {Humidity} % humidity");
    }
}
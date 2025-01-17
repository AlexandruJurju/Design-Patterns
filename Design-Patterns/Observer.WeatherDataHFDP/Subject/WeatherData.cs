using Observer.WeatherData.Observers;

namespace Observer.WeatherData.Subject;

public class WeatherData : ISubject
{
    private List<IObserver> observers = new();
    public double Temperature { get; set; }
    public double Humidity { get; set; }
    public double Pressure { get; set; }


    public void RegisterObserver(IObserver observer)
    {
        observers.Add(observer);
    }

    public void RemoveObserver(IObserver observer)
    {
        observers.Remove(observer);
    }

    public void NotifyObservers()
    {
        foreach (var observer in observers)
        {
            observer.Update(Temperature, Humidity, Pressure);
        }
    }

    public void MeasurementsChanged()
    {
        NotifyObservers();
    }

    public void SetMeasurements(double temperature, double humidity, double pressure)
    {
        Temperature = temperature;
        Humidity = humidity;
        Pressure = pressure;
        MeasurementsChanged();
    }
}
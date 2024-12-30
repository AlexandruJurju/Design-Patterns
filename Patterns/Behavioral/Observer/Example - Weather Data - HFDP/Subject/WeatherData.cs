using Observer.Observers;

namespace Observer.Subject;

public class WeatherData : ISubject
{
    private List<IObserver> observers = new();
    public double Temperature { get; set; }
    public double Humidity { get; set; }
    public double Pressure { get; set; }


    public void registerObserver(IObserver observer)
    {
        observers.Add(observer);
    }

    public void removeObserver(IObserver observer)
    {
        observers.Remove(observer);
    }

    public void notifyObservers()
    {
        foreach (var observer in observers)
        {
            observer.Update(Temperature, Humidity, Pressure);
        }
    }

    public void MeasurementsChanged()
    {
        notifyObservers();
    }

    public void SetMeasurements(double temperature, double humidity, double pressure)
    {
        Temperature = temperature;
        Humidity = humidity;
        Pressure = pressure;
        MeasurementsChanged();
    }
}
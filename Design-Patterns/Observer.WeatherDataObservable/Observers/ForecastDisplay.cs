using Observer.WeatherDataObservable.Subjects;

namespace Observer.WeatherDataObservable.Observers;

public class ForecastDisplay : IObserver<WeatherData>, IDisplayElement
{
    private readonly IDisposable _unsubscriber;
    private double _currentPressure;
    private double _lastPressure;

    public ForecastDisplay(IObservable<WeatherData> weatherData)
    {
        _unsubscriber = weatherData.Subscribe(this);
    }

    public void Display()
    {
        Console.Write("Forecast: ");
        if (_currentPressure > _lastPressure)
        {
            Console.WriteLine("Improving weather on the way!");
        }
        else if (Math.Abs(_currentPressure - _lastPressure) < 0.01f)
        {
            Console.WriteLine("More of the same");
        }
        else if (_currentPressure < _lastPressure)
        {
            Console.WriteLine("Watch out for cooler, rainy weather");
        }
    }

    public void OnCompleted()
    {
        Console.WriteLine("Weather station has completed transmitting data");
        _unsubscriber.Dispose();
    }

    public void OnError(Exception error)
    {
        Console.WriteLine("Error occured {0}", error);
    }

    public void OnNext(WeatherData value)
    {
        _lastPressure = _currentPressure;
        _currentPressure = value.Pressure;

        Display();
    }
}
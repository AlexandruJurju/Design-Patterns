using Observer.WeatherWithObservable.Subjects;

namespace Observer.WeatherWithObservable.Observers;

public class StatisticsDisplay : IObserver<WeatherData>, IDisplayElement
{
    private readonly IDisposable _unsubscriber;
    private double _maxTemp;
    private double _minTemp = 200;
    private int _numReadings;
    private double _tempSum;

    public StatisticsDisplay(IObservable<WeatherData> weatherData)
    {
        _unsubscriber = weatherData.Subscribe(this);
    }

    public void Display()
    {
        Console.WriteLine("Avg/Max/Min temperature = " + _tempSum / _numReadings + "/" + _maxTemp + "/" + _minTemp);
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
        _tempSum += value.Temperature;
        _numReadings++;

        if (value.Temperature > _maxTemp) _maxTemp = value.Temperature;

        if (value.Temperature < _minTemp) _minTemp = value.Temperature;

        Display();
    }
}
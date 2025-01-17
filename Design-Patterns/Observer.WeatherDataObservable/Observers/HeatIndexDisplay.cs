using Observer.WeatherDataObservable.Subjects;

namespace Observer.WeatherDataObservable.Observers;

public class HeatIndexDisplay : IObserver<WeatherData>, IDisplayElement
{
    private double _heatIndex;

    private readonly IDisposable _unsubscriber;

    public HeatIndexDisplay(IObservable<WeatherData> weatherData)
    {
        _unsubscriber = weatherData.Subscribe(this);
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
        _heatIndex = ComputeHeatIndex(value.Temperature, value.Humidity);
        Display();
    }

    private double ComputeHeatIndex(double temperature, double relativeHumidity)
    {
        double index = (16.923 + (0.185212 * temperature) + (5.37941 * relativeHumidity) - (0.100254 * temperature * relativeHumidity)
                        + (0.00941695 * (temperature * temperature)) + (0.00728898 * (relativeHumidity * relativeHumidity))
                        + (0.000345372 * (temperature * temperature * relativeHumidity)) - (0.000814971 * (temperature * relativeHumidity * relativeHumidity)) +
                        (0.0000102102 * (temperature * temperature * relativeHumidity * relativeHumidity)) - (0.000038646 * (temperature * temperature * temperature)) + (0.0000291583 *
                            (relativeHumidity * relativeHumidity * relativeHumidity)) + (0.00000142721 * (temperature * temperature * temperature * relativeHumidity)) +
                        (0.000000197483 * (temperature * relativeHumidity * relativeHumidity * relativeHumidity)) -
                        (0.0000000218429 * (temperature * temperature * temperature * relativeHumidity * relativeHumidity)) +
                        0.000000000843296 * (temperature * temperature * relativeHumidity * relativeHumidity * relativeHumidity)) -
                       (0.0000000000481975 * (temperature * temperature * temperature * relativeHumidity * relativeHumidity * relativeHumidity));
        return index;
    }

    public void Display()
    {
        Console.WriteLine("Heat index is " + _heatIndex);
    }
}
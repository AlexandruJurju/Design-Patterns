public class TemperatureDisplay : IObserver<WeatherStation>
{
    public void OnCompleted()
    {
        Console.WriteLine("Temperature Display: Monitoring completed");
    }

    public void OnError(Exception error)
    {
        Console.WriteLine($"Temperature Display Error: {error.Message}");
    }

    public void OnNext(WeatherStation station)
    {
        Console.WriteLine($"Temperature Display: Current temperature is {station.Temperature}°C");
    }
}
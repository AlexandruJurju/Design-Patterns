public class WeatherStatsDisplay : IObserver<WeatherStation>
{
    public void OnCompleted()
    {
        Console.WriteLine("Weather Stats Display: Monitoring completed");
    }

    public void OnError(Exception error)
    {
        Console.WriteLine($"Weather Stats Display Error: {error.Message}");
    }

    public void OnNext(WeatherStation station)
    {
        Console.WriteLine($"Weather Stats Display: Temperature: {station.Temperature}°C, " +
                          $"Humidity: {station.Humidity}%, Pressure: {station.Pressure}hPa");
    }
}
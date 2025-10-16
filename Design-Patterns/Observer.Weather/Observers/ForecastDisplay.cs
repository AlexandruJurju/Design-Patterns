using Observer.Weather.Subject;

namespace Observer.Weather.Observers;

public class ForecastDisplay : IObserver, IDisplayElement
{
    private double _currentPressure = 29.92d;
    private double _lastPressure;

    public ForecastDisplay(ISubject weatherData)
    {
        weatherData.RegisterObserver(this);
    }

    public void Display()
    {
        Console.Write("Forecast: ");
        if (_currentPressure > _lastPressure)
            Console.WriteLine("Improving weather on the way!");
        else if (_currentPressure == _lastPressure)
            Console.WriteLine("More of the same");
        else if (_currentPressure < _lastPressure) Console.WriteLine("Watch out for cooler, rainy weather");
    }

    public void Update(double temp, double humidity, double pressure)
    {
        _lastPressure = _currentPressure;
        _currentPressure = pressure;

        Display();
    }
}
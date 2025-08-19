namespace Observer.WeatherWithObservable.Subjects;

public class WeatherData : IObservable<WeatherData>
{
    private readonly List<IObserver<WeatherData>> _observers;

    public WeatherData()
    {
        _observers = new List<IObserver<WeatherData>>();
    }

    public double Temperature { get; private set; }
    public double Humidity { get; private set; }
    public double Pressure { get; private set; }

    public IDisposable Subscribe(IObserver<WeatherData> observer)
    {
        if (!_observers.Contains(observer))
            _observers.Add(observer);

        return new Unsubscriber(_observers, observer);
    }

    private void MeasurementsChanged()
    {
        foreach (var observer in _observers)
        {
            observer.OnNext(this);
        }
    }

    public void SetMeasurements(double temperature, double humidity, double pressure)
    {
        Temperature = temperature;
        Humidity = humidity;
        Pressure = pressure;
        MeasurementsChanged();
    }

    private class Unsubscriber : IDisposable
    {
        private readonly IObserver<WeatherData> _observer;
        private readonly List<IObserver<WeatherData>> _observers;

        public Unsubscriber(List<IObserver<WeatherData>> observers, IObserver<WeatherData> observer)
        {
            _observers = observers;
            _observer = observer;
        }

        public void Dispose()
        {
            if (_observer != null && _observers.Contains(_observer))
                _observers.Remove(_observer);
        }
    }
}
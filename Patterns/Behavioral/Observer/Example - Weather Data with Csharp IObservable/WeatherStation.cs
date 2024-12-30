public class WeatherStation : IObservable<WeatherStation>
{
    private List<IObserver<WeatherStation>> observers;
    
    public double Temperature { get; private set; }
    public double Humidity { get; private set; }
    public double Pressure { get; private set; }

    public WeatherStation()
    {
        observers = new List<IObserver<WeatherStation>>();
    }

    public IDisposable Subscribe(IObserver<WeatherStation> observer)
    {
        if (!observers.Contains(observer))
        {
            observers.Add(observer);
            observer.OnNext(this);
        }
        return new Unsubscriber(observers, observer);
    }

    public void UpdateWeather(double temperature, double humidity, double pressure)
    {
        Temperature = temperature;
        Humidity = humidity;
        Pressure = pressure;
        NotifyObservers();
    }

    private void NotifyObservers()
    {
        foreach (var observer in observers)
        {
            observer.OnNext(this);
        }
    }

    private class Unsubscriber : IDisposable
    {
        private List<IObserver<WeatherStation>> _observers;
        private IObserver<WeatherStation> _observer;

        public Unsubscriber(List<IObserver<WeatherStation>> observers, IObserver<WeatherStation> observer)
        {
            _observers = observers;
            _observer = observer;
        }

        public void Dispose()
        {
            if (_observer != null && _observers.Contains(_observer))
            {
                _observers.Remove(_observer);
            }
        }
    }
}
var weatherStation = new WeatherStation();
        
var temperatureDisplay = new TemperatureDisplay();
var weatherStatsDisplay = new WeatherStatsDisplay();

IDisposable temperatureSubscription = weatherStation.Subscribe(temperatureDisplay);
IDisposable statsSubscription = weatherStation.Subscribe(weatherStatsDisplay);

weatherStation.UpdateWeather(25.5, 65, 1013);
temperatureSubscription.Dispose();
weatherStation.UpdateWeather(26.8, 70, 1014);
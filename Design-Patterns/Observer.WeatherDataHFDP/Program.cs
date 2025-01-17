using Observer.WeatherData.Observers;
using Observer.WeatherData.Subject;

WeatherData weatherData = new WeatherData();
CurrentConditionsDisplay currentDisplay = new CurrentConditionsDisplay(weatherData);
StatisticsDisplay statisticsDisplay = new StatisticsDisplay(weatherData);
ForecastDisplay forecastDisplay = new ForecastDisplay(weatherData);
HeatIndexDisplay heatIndexDisplay = new HeatIndexDisplay(weatherData);

weatherData.SetMeasurements(80, 65, 30.4d);
Console.WriteLine();
weatherData.SetMeasurements(82, 70, 29.2d);
Console.WriteLine();
weatherData.SetMeasurements(78, 90, 29.2d);
Console.WriteLine();

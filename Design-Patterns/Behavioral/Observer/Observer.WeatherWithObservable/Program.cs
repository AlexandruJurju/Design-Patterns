using Observer.WeatherWithObservable.Observers;
using Observer.WeatherWithObservable.Subjects;

var weatherData = new WeatherData();

var currentDisplay = new CurrentConditionsDisplay(weatherData);
var statisticsDisplay = new StatisticsDisplay(weatherData);
var forecastDisplay = new ForecastDisplay(weatherData);
var heatIndexDisplay = new HeatIndexDisplay(weatherData);

weatherData.SetMeasurements(80, 65, 30.4d);
Console.WriteLine();

weatherData.SetMeasurements(82, 70, 29.2d);
Console.WriteLine();

weatherData.SetMeasurements(78, 90, 29.2d);
Console.WriteLine();
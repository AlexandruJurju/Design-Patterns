using Observer.WeatherEvents.Observers;
using Observer.WeatherEvents.Subject;

var weatherStation = new WeatherStation();
var forecastDisplay = new ForecastDisplay(weatherStation);
var statisticsDisplay = new StatisticsDisplay(weatherStation);

weatherStation.SetMeasurements(80, 65, 30.4d);
Console.WriteLine();
weatherStation.SetMeasurements(82, 70, 29.2d);
Console.WriteLine();
weatherStation.SetMeasurements(78, 90, 29.2d);
Console.WriteLine();

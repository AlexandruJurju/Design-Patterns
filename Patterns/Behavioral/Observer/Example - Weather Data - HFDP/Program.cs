using Observer.Observers;
using Observer.Subject;

WeatherData weatherData = new WeatherData();
CurrentConditionsDisplay currentConditionsDisplay = new CurrentConditionsDisplay(weatherData);
StatisticsDisplay statisticsDisplay = new StatisticsDisplay(weatherData);

weatherData.SetMeasurements(20, 20, 19);
weatherData.SetMeasurements(222, 111, 233);
namespace ObserverPattern;

public class WeatherStation {
    static void Main() {
        // first, create the WeatherData object
        WeatherData weatherData = new();

        // create the three displays and pass them the WeatherData object
        CurrentConditionsDisplay currentDisplay = new(weatherData);
        StatisticsDisplay statisticsDisplay = new(weatherData);
        ForecastDisplay forecastDisplay = new(weatherData);

        // simulate new weather measurements
        weatherData.SetMeasurements(80, 65, 30.4f);
        weatherData.SetMeasurements(82, 70, 29.2f);
        weatherData.SetMeasurements(78, 90, 29.2f);

        weatherData.RemoveObserver(forecastDisplay);
        weatherData.SetMeasurements(62, 90, 28.1f);

        HeadIndexDisplay heatIndexDisplay = new(weatherData);

        weatherData.SetMeasurements(80, 65, 30.4f);
        weatherData.SetMeasurements(82, 70, 29.2f);
        weatherData.SetMeasurements(78, 90, 29.2f);
    }
}

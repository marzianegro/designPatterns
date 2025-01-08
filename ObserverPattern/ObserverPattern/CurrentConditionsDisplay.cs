using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern;

// this display element shows the current measurements from the WeatherData object
// this display implements the Observer interface to it can get changes from the WeatherData object
// it also implements DisplayElement, because our API is going to require all display elements to implement this interface
public class CurrentConditionsDisplay : IObserver, IDisplayElement {
    private float temperature;
    private float humidity;
    private WeatherData weatherData;

    // the constructor is passed the weatherData object (the Subject)
    // and we use it to register the display as an observer
    public CurrentConditionsDisplay(WeatherData weatherData) {
        this.weatherData = weatherData;
        weatherData.RegisterObserver(this);
    }

    // when update() is called, we save the temp and humidity and call display()
    // public void Update(float temperature, float humidity, float pressure) {
    //     this.temperature = temperature;
    //     this.humidity = humidity;
    //     Display();
    // }

    // here we're using the Subject's getter methods
    public void Update() {
        this.temperature = weatherData.GetTemperature();
        this.humidity = weatherData.GetHumidity();
        Display();
    }

    // the display() method just prints out the most recent temp and humidity
    public void Display() {
        Console.WriteLine("Current conditions: " + temperature
            + "F degrees and " + humidity + "% humidity");
    }
}

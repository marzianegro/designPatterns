using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace observerPattern;

// this display shows the weather forecast based on the barometer
public class ForecastDisplay : IObserver, IDisplayElement {
    private float currentPressure = 29.9f;
    private float lastPressure;
    public WeatherData weatherData;

    public ForecastDisplay(WeatherData weatherData) {
        this.weatherData = weatherData;
        weatherData.RegisterObserver(this);
    }

    // public void Update(float temp, float humidity, float pressure) {
    //     lastPressure = currentPressure;
    //     currentPressure = pressure;
    //     Display();
    // }

    public void Update() {
        lastPressure = currentPressure;
        currentPressure = weatherData.GetPressure();
        Display();
    }

    public void Display() {
        Console.WriteLine("Forecast: ");
        if (currentPressure > lastPressure) {
            Console.WriteLine("Improving weather on the way!");
        } else if (currentPressure == lastPressure) {
            Console.WriteLine("More of the same");
        } else if (currentPressure < lastPressure) {
            Console.WriteLine("Watch out for cooler, rainy weather");
        }
    }
}

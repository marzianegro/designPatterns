﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern;

// this one keeps track of the min/avg/max measurements and displays them
public class StatisticsDisplay : IObserver, IDisplayElement {
    private float maxTemp = 0.0f;
    private float minTemp = 200;
    private float tempSum = 0.0f;
    private int numReadings;
    private WeatherData weatherData;

    public StatisticsDisplay(WeatherData weatherData) {
        this.weatherData = weatherData;
        weatherData.RegisterObserver(this);
    }

    //public void Update(float temp, float humidity, float pressure) {
    //    tempSum += temp;
    //    numReadings++;

    //    if (temp > maxTemp) {
    //        maxTemp = temp;
    //    }
    //    if (temp < minTemp) {
    //        minTemp = temp;
    //    }

    //    Display();
    //}

    public void Update() {
        float temp = weatherData.GetTemperature();

        tempSum += temp;
        numReadings++;

        if (temp > maxTemp) {
            maxTemp = temp;
        }
        if (temp < minTemp) {
            minTemp = temp;
        }

        Display();
    }

    public void Display() {
        Console.WriteLine("Avg/Max/Min temperature = " + (tempSum / numReadings)
            + "/" + maxTemp + "/" + minTemp);
    }
}

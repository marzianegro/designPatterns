namespace observerPattern;

// WeatherData now implements the Subject interface
public class WeatherData : ISubject {
    // we've added a List to hold the Observers, and we create it in the constructor
    private List<IObserver> observers;
    private float temperature;
    private float humidity;
    private float pressure;
    
    public WeatherData() {
        observers = new List<IObserver>();
    }

    // here we implement the Subject interface
    public void RegisterObserver(IObserver o) {
        // when an observer registers, we just add it to the end of the list
        observers.Add(o);
    }

    public void RemoveObserver(IObserver o) {
        // likewise, when an observer wants to un-register, we just take it off the list
        observers.Remove(o);
    }

    public void NotifyObservers() {
        // here's the fun part; this is where we tell all the observers about the state.
        // because they are all Observers, we know they all implement update(), so we
        // know how to notify them
        foreach (IObserver observer in observers) {
            // observer.Update(temperature, humidity, pressure);

            // let's set things up so that when an Observer is notified of a change, it calls
            // getter methods on the Subject to ~pull~ the values it needs
            observer.Update();
        }

    }

    // we notify the Observers when we get updates measurements from the Weather Station
    public void MeasurementsChanged() {
        NotifyObservers();
    }
/*  
    // this method gets called whenever the weather measurements have been updated
    public void MeasurementsChanged() {
        //first, we grab the most recent measurements by calling the WeatherData's getter methods.
        // we assign each value to an appropriately named variable

        // looks liks an area of change -> we need to encapsulate this
        float temp = GetTemperature();
        float humidity = GetHumidity();
        float pressure = GetPressure();

        // next, we're going to update each display by calling its update method and passing it
        // the most recent measurements

        // by coding to concrete implementations, we have no way to add or remove other display elements without making changes to the code
        currentConditionsDisplay.Update(temp, humidity, pressure);
        statisticsDisplay.Update(temp, humidity, pressure);
        forecastDisplay.Update(temp, humidity, pressure);
        // at least we seem to be using a common interface to talk to the display elements... they all have an update()
        // method that takes the temp, humidity, and pressure values
    }
*/

    // okay, while we wanted to ship a nice little weather station with each book, the publisher wouldn't go for it.
    // so, rather than reading actual weather data off a device, we're going to use this method to test our display elements.
    public void SetMeasurements(float temperature, float humidity, float pressure) {
        this.temperature = temperature;
        this.humidity = humidity;
        this.pressure = pressure;
        MeasurementsChanged();
    }

    // these three methods return the most recent weather measurements for temperature,
    // humidity, and barometric presure, respectively
    public float GetTemperature() {
        return temperature;
    }

    public float GetHumidity() {
        return humidity;
    }

    public float GetPressure() {
        return pressure;
    }
}

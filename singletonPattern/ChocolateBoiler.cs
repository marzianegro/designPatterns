namespace singletonPattern;

public class ChocolateBoiler {
    private bool empty;
    private bool boiled;


    private static ChocolateBoiler uniqueInstance;

    private ChocolateBoiler() {
        empty = true;
        boiled = false;
    }

    public static ChocolateBoiler GetInstance() {
        if (uniqueInstance == null) {
            Console.WriteLine("Creating unique instance of Chocolate Boiler");
            uniqueInstance = new ChocolateBoiler();
        }
        Console.WriteLine("Returning instance of Chocolate Boiler");
        return uniqueInstance;
    }

    public void Fill() {
        // to fill the boiler it must be empty, and, once it's full
        // we set the empty and boiled flags
        if (IsEmpty()) {
            empty = false;
            boiled = false;
            // fill the boiler with a milk/chocolate mixture
        }
    }

    public void Drain() {
        // to drain the boiler, it must be full (non-empty)
        // and also boiled. once it is drained, we set empty
        // back to true
        if (!IsEmpty() && IsBoiled()) {
            // drain the boiled milk and chocolate
            empty = true;
        }
    }

    public void Boil() {
        // to boil the mixture, the boiler has to be full and
        // not already boiled. once it's boiled, we set the
        // boiled flag to true
        if (!IsEmpty() && !IsBoiled()) {
            // brind the contents to a boil
            boiled = true;
        }
    }

    public bool IsEmpty() { 
        return empty;
    }

    public bool IsBoiled() {
        return boiled;
    }
}

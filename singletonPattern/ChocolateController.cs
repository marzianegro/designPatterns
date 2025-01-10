namespace singletonPattern;

public class ChocolateController {
    static void Main() {
        ChocolateBoiler boiler = ChocolateBoiler.GetInstance();
        boiler.Fill();
        boiler.Boil();
        boiler.Drain();

        // will return the existing instance
        ChocolateBoiler boiler2 = ChocolateBoiler.GetInstance();
    }
}

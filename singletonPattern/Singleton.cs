namespace singletonPattern;

public class Singleton {
    private static Singleton uniqueInstance;

    private Singleton() { }

    public static Singleton GetInstance() { 
        if (uniqueInstance == null) {
            uniqueInstance = new Singleton();
        }
        return uniqueInstance;
    }

    // other useful methods here
    public string GetDescription() {
        return "I'm a classic Singleton!";
    }
}

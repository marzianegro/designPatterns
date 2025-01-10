namespace singletonThreadSafe;

public class Singleton {
    private static Singleton uniqueInstance;
    // object for locking to ensure thread safety
    private static readonly object lockObject = new();

    private Singleton() { }

    public static Singleton GetInstance() {
        lock (lockObject) {
            if (uniqueInstance == null) {
                uniqueInstance = new Singleton();
            }
        }
        return uniqueInstance;
    }

    public string GetDescription() {
        return "I'm a thread safe Singleton!";
    }
}
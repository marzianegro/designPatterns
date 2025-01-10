namespace singletonSubclass;

public class Singleton {
    protected static Singleton uniqueInstance;

    protected Singleton() { }

    public static Singleton GetInstance() {
        lock(typeof(Singleton)) { // synchronizing access
            if (uniqueInstance == null) {
                uniqueInstance = new Singleton();
            }
        }
        return uniqueInstance;
    }
}

namespace singletonPattern;

public class SingletonDCL {
    // volatile ensures that uniqueInstance is not cached by threads, and changes are visible to all threads
    private static volatile SingletonDCL uniqueInstance;
    private static readonly object lockObject = new();

    private SingletonDCL() { }

    public static SingletonDCL GetInstance() {
        if (uniqueInstance == null) {
            // ensures thread safety by allowing only one thread to enter the critical section at a time
            lock (lockObject) {
                if (uniqueInstance == null) {
                    uniqueInstance = new SingletonDCL();
                }
            }
        }
        return uniqueInstance;
    }
}


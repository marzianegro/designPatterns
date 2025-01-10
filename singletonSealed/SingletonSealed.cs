namespace singletonPattern;

public sealed class SingletonSealed {
    // static instance initialized lazily by the CLR
    private static readonly SingletonSealed uniqueInstance = new();
    public static SingletonSealed UniqueInstance {
        get {
            return uniqueInstance;
        }
    }

    private SingletonSealed() { }

    // other useful methods here
    public string GetDescription() {
        return "I'm a thread safe Singleton!";
    }
}
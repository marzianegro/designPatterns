namespace singletonSubclass;

public class CoolerSingleton : Singleton {
    protected static Singleton uniqueInstance;

    private CoolerSingleton() : base() { }
}

namespace singletonSubclass;

internal class SingletonTestDrive {
    static void Main(string[] args) {
        Singleton foo = CoolerSingleton.GetInstance();
        Singleton bar = HotterSingleton.GetInstance();
        Console.WriteLine(foo);
        Console.WriteLine(bar);
    }
}

namespace singletonThreadSafe;

internal class SingletonClient {
    static void Main() {
        Singleton singleton = Singleton.GetInstance();
        Console.WriteLine(singleton.GetDescription());
    }
}

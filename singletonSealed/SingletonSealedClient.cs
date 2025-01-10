namespace singletonPattern;

public class SingletonSealedClient {
    static void Main() {
        SingletonSealed singleton = SingletonSealed.UniqueInstance;
        Console.WriteLine(singleton.GetDescription());
    }
}
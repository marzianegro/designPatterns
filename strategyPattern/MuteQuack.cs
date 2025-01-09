namespace strategyPattern;

public class MuteQuack : IQuackBehavior {
    public void Quack() {
        // do nothing - can't quack!
        Console.WriteLine("<<< Silence >>>");
    }
}

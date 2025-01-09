namespace strategyPattern;

public class RealQuack : IQuackBehavior {
    public void Quack() {
        // implements duck quacking
        Console.WriteLine("Quack");
    }
}

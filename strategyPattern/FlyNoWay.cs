namespace strategyPattern;

public class FlyNoWay : IFlyBehavior {
    public void Fly() {
        // flying behavior implementation for ducks that do NOT fly (like rubbber ducks and decoy ducks)
        Console.WriteLine("I can't fly");
    }
}
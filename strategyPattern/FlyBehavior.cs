namespace strategyPattern;

// the interface that all flying classes implement
public interface IFlyBehavior {
    // all new flying classes just need to implement the Fly() method
    public void Fly();
}

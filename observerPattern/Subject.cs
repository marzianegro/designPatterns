namespace observerPattern;

// here's our Subject interface
public interface ISubject {
    // both of these methods take an Observer as an argument-that is, the Observer to be registered or removed
    void RegisterObserver(IObserver o);
    void RemoveObserver(IObserver o);
    // this method is called to notify all observers when the Subject's state has changed
    void NotifyObservers();
}

namespace observerPattern;

// developers can implement the Observer and DisplayElement interfaces to create their own display element
public class ThirdPartyDisplay : IObserver, IDisplayElement {
    //public void Update(float temp, float humidity, float pressure) {
    //    throw new NotImplementedException();
    //}

    public void Update() {
        throw new NotImplementedException();
    }

    public void Display() {
        throw new NotImplementedException();
    }
}

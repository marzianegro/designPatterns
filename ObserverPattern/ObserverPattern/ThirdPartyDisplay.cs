using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern;

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

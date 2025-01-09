using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace observerPattern;

// all our weather components implement the Observer interface.
// this gives the Subject a common interface to talk to when it comes time to update the observers
public interface IObserver {
    // the Observer interface is implemented by all observers, to they all have to implement the update() method.
    // there are the state values the Observers get from the SUbject when a weather measurement changes
    
    // void Update(float temp, float humidity, float pressure);
    void Update();
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace observerPattern;

// let's also create an interface for all display elements to implement.
// the display elements just need to implement a display() method
public interface IDisplayElement {
    // the DisplayElement interface just includes one method, display(), that
    // we will call when the display element needs to be displayed
    void Display();
}

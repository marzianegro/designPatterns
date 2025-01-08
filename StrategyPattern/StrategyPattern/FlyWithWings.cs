using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern;

public class FlyWithWings : IFlyBehavior {
    public void Fly() {
        // flying behavior implementation for ducks that DO fly...
        Console.WriteLine("I'm flying!!");
    }
}

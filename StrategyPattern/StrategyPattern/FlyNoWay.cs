using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern;

public class FlyNoWay : IFlyBehavior {
    public void Fly() {
        // flying behavior implementation for ducks that do NOT fly (like rubbber ducks and decoy ducks)
        Console.WriteLine("I can't fly");
    }
}
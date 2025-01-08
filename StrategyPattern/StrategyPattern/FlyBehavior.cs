using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern;

// the interface that all flying classes implement
public interface IFlyBehavior {
    // all new flying classes just need to implement the Fly() method
    public void Fly();
}

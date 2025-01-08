using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern;

public class DecoyDuck : Duck {
    public override void Display() {
        Console.WriteLine("I'm a decoy duck");
    }
}

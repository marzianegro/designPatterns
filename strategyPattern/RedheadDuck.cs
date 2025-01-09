using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace strategyPattern;

public class RedheadDuck : Duck {
    public RedheadDuck() { }

    public override void Display() {
        Console.WriteLine("I'm a real Redhead duck");
    }
}

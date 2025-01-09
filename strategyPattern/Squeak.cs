using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace strategyPattern;

public class Squeak : IQuackBehavior {
    public void Quack() {
        // rubber duckie squeak
        Console.WriteLine("Squeak");
    }
}

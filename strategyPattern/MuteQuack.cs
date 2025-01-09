using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace strategyPattern;

public class MuteQuack : IQuackBehavior {
    public void Quack() {
        // do nothing - can't quack!
        Console.WriteLine("<<< Silence >>>");
    }
}

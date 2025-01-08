using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern;

public class MallardDuck : Duck {
    // MallardDuck inherits the quackBehavior and flyBehavior instance variables from class Duck

    public MallardDuck() {
        // MallardDuck uses the Quack class to handle its quack, so when PerformQuack() is called, the responsibility
        // for the quack is delegated to the Quack object and we get a real quack
        quackBehavior = new RealQuack();
        // and it uses FlyWithWings as its FlyBehavior type
        flyBehavior = new FlyWithWings();
    }

    public override void Display() {
        Console.WriteLine("I'm a real Mallard duck");
    }
}

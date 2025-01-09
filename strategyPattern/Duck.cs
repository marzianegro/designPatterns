using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace strategyPattern;

public abstract class Duck {
    // declare two reference variables for the behavior interface types.
    // all duck subclasses (in the same package) inherit these
    protected IFlyBehavior flyBehavior;
    protected IQuackBehavior quackBehavior;

    public Duck() { }

    public void Swim() {
        Console.WriteLine("All ducks float, even decoys!");
    }
    
    public abstract void Display();
    
    public void PerformQuack() {
        // rather than handling the quack behavior itself, the Duck object
        // delegates that behavior to the object referenced by quackBehavior
        quackBehavior.Quack();
    }
    public void SetFlyBehavior(IFlyBehavior fb) {
        flyBehavior = fb;
    }
    
    public void PerformFly() {
        flyBehavior.Fly(); // delegate to the behavior class
    }
    public void SetQuackBehavior(IQuackBehavior qb) {
        quackBehavior = qb;
    }

    // other duck-like methods...
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern;

// if a franchise wants NY-style pizzas for its customers, it uses
// the NY subclass, which has its own CreatePizza() method, creating
// NY-style pizzas

// CreatePizza() returns a Pizza, and the subclass is fully responsible for
// which concrete Pizza it instantiates

// the NYPizzaStore extends PizzaStore, so it inherits the OrderPizza() method (among others)
public class NYPizzaStore : PizzaStore {
    // remember: CreatePizza() is abstract in PizzaStore, so all
    // pizza store subtypes MUST implement the method

    // we've got to implement CreatePizza(), since it is abstract in PizzaStore
    protected override Pizza CreatePizza(string item) {
        // here's where we create our concrete classes.
        // for each type of Pizza we create the NY style
        if (item.Equals("cheese")) {
            return new NYStyleCheesePizza();
        } else if (item.Equals("pepperoni")) {
            return new NYStylePepperoniPizza();
        } else if (item.Equals("clam")) {
            return new NYStyleClamPizza();
        } else if (item.Equals("veggie")) {
            return new NYStyleVeggiePizza();
        } else {
            return null;
        }
    }
}

// note that the OrderPizza() method in the superclass has no clue which Pizza
// we are creating; it just knows it can prepare, bake, cut, and box it!

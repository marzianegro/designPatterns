using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using simpleFactory;

namespace FactoryPattern;

// this is the *factory* where we create pizzas;
// it should be the only part of our application that
// refers to concrete Pizza classes
public class SimplePizzaFactory {
    public SimplePizzaFactory() { }

    // the create method is often declared statically
    public Pizza CreatePizza(string type) {
        Pizza pizza = null;

        if (type.Equals("cheese")) {
            pizza = new CheesePizza();
        } else if (type.Equals("pepperoni")) {
            pizza = new PepperoniPizza();
        } else if (type.Equals("clam")) {
            pizza = new ClamPizza();
        } else if (type.Equals("veggie")) {
            pizza = new VeggiePizza();
        }
        return pizza;
    }
}
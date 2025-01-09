using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern;

// PizzaStore is now abstract

// each subclass provides an implementation of the CreatePizza() method, overriding
// the abstract CreatePizza() method in PizzaStore, while all subclasses make use of the
// OrderPizza() method defined in PizzaStore. we could make the OrderPizza() method final
// if we really wanted to enforce this
public abstract class PizzaStore {
    public PizzaStore() { }

    // OrderPizza() is defined in the abstract PizzaStore, not the subclasses.
    // so, the method has no idea which subclass is actually running the code and
    // making the pizzas

    // the subclasses of PizzaStore handle object instantiation for us in the CreatePizza() method
    public Pizza OrderPizza(string type) {
        Pizza pizza;

        // now CreatePizza is back to being a call to a method in the PizzaStore
        // rather than on a factory object
        
        // OrderPizza() calls CreatePizza() to actually get a pizza object. but
        // which kind of pizza will it get? the OrderPizza() method can't decide;
        // it doesn't know how. so who *does* decide?
        pizza = CreatePizza(type);

        // all this looks just the same...
        pizza.Prepare();
        pizza.Bake();
        pizza.Cut();
        pizza.Box();

        return pizza;
    }

    // now we've moved our factory object to this method
    
    // all the responsibility for instantiating Pizzas has been moved into a *method* that acts as a *factory*
    protected abstract Pizza CreatePizza(string item); // our "factory method" is now abstract in PizzaStore
}
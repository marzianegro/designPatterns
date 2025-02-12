﻿namespace factoryMethod;

// similarly, by using the Chicago subclass, we get an implementation
// of CreatePizza() with Chicago ingredients
public class ChicagoPizzaStore : PizzaStore {
    // remember: CreatePizza() is abstract in PizzaStore, so all
    // pizza store subtypes MUST implement the method
    protected override Pizza CreatePizza(string item) {
        if (item.Equals("cheese")) {
            return new ChicagoStyleCheesePizza();
        } else if (item.Equals("pepperoni")) {
            return new ChicagoStylePepperoniPizza();
        } else if (item.Equals("clam")) {
            return new ChicagoStyleClamPizza();
        } else if (item.Equals("veggie")) {
            return new ChicagoStyleVeggiePizza();
        } else {
            return null;
        }
    }
}
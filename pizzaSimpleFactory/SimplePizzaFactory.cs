namespace simpleFactory;

// this is the *factory* where we create pizzas; it should be the only
// part of our application that refers to concrete Pizza classes

// first we pull the object creation code out of the OrderPizza() method

// then we place that code in an object that is going to worry about
// how to create pizzas. if any other object needs a pizza created,
// this is the object to come to

// here's our new class, the SimplePizzaFactory. it has onejob in life:
// creating pizzas for its clients.
public class SimplePizzaFactory {
    public SimplePizzaFactory() { }

    // the create method is often declared statically

    // first we define a CreatePizza() method in the factory. this is
    // the method all clients will use to instantiate new objects.
    public Pizza CreatePizza(string type) {
        Pizza pizza = null;

        // here's the code we plucked out of the OrderPizza() method

        // this code is still parametrized by the type of pizza,
        // just like our original OrderPizza() method was
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
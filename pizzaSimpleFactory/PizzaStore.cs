namespace simpleFactory;

// this is the *client* of the factory.
// PizzaStore now goes through the SimplePizzaFactory
// to get instances of pizza
public class PizzaStore {
    // first we give PizzaStore a reference to a SimplePizzaFactory
    SimplePizzaFactory factory;

    // PizzaStore gets the factory passed to it in the constructor
    public PizzaStore(SimplePizzaFactory factory) { 
        this.factory = factory;
    }

    public Pizza OrderPizza(string type) {
        Pizza pizza;

        // and the OrderPizza() method uses the factory to create its pizzas
        // by simply passing on the type of the order

        // notice that we've replaced the "new" operator with a CreatePizza() method
        // in the factory object. no more concrete instantiations here!
        pizza = factory.CreatePizza(type);

        pizza.Prepare();
        pizza.Bake();
        pizza.Cut();
        pizza.Box();

        return pizza;
    }
}
namespace simpleFactory;

// this is the *client* of the factory. PizzaStore now goes through the
// SimplePizzaFactory to get instances of pizza
public class PizzaStore {
    // first we give PizzaStore a reference to SimplePizzaFactory
    SimplePizzaFactory factory;

    // PizzaStore gets the factory passed to it in the constructor
    public PizzaStore(SimplePizzaFactory factory) { 
        this.factory = factory;
    }

    // we're now passing in the type of pizza to OrderPizza
    public Pizza OrderPizza(string type) {
        // for flexibility, we really want this to be an abstract class or interface,
        // but unfortunately we can't directly instantiate either of those
        Pizza pizza;

        // based on the type of pizza, we instantiate the correct concrete class
        // and assing it to the pizza instance variable. note that each pizza here
        // has to implement the Pizza interface

        // this code is NOT closed for modification. if the Pizza Store changes its
        // pizza offerings, we have to open this code and modify it.
        
        // this is what varies. as the pizza selection changes over time, you'll
        // have to modify this code over and over
        if (type.Equals("cheese")) {
            pizza = new CheesePizza();
        } else if (type.Equals("pepperoni")) {
            pizza = new PepperoniPizza();
        } else if (type.Equals("clam")) {
            pizza = new ClamPizza();
        } else if (type.Equals("veggie")) {
            pizza = new VeggiePizza();
        }

        // and the OrderPizza() method uses the factory to create its
        // pizzas by simply passing on the type of the order

        // notice that we've replaced the "new" operator with a CreatePizza() method
        // in the factory object. no more concrete instantiations here!
        pizza = factory.CreatePizza(type);

        // once we have a Pizza, we prepare it (you know, roll the dough, put on
        // the sauche, and add the toppings), then we bake it, cut it, and box it!
        // each Pizza subtype (CheesePizza, GreekPizza, etc.) knows how to preare itself

        // this is what we expect to stay the same. for the most part, preparing, cooking, and
        // packaging a pizza has remained the same for years and years. so, we don't expect this
        // code to change, just the pizzas it operates on
        pizza.Prepare();
        pizza.Bake();
        pizza.Cut();
        pizza.Box();

        return pizza;
    }
}
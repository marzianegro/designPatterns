namespace factoryMethod;

public class PizzaTestDrive {
    static void Main(string[] args) {
    /*
        // here we create a factory for making NY-style pizzas
        NYPizzaFactory nyFactory = new();
        // then we create a PizzaStore and pass it a reference to the NY factory
        PizzaStore nyStore = new(nyFactory);
        //... and when we make pizzas, we get NY-style pizzas
        nyStore.OrderPizza("veggie");

        // likewise for the Chicago pizza stores: we create a factory for Chicago pizza
        ChicagoPizzaFactory chicagoFactory = new();
        // and create a store that is composed with a Chicago factory.
        PizzaStore chicagoStore = new(chicagoFactory);
        // when we make pizzas, we get the Chicago-style ones
        chicagoStore.OrderPizza("veggie");
    */

        // first we create two different stores
        PizzaStore nyStore = new NYPizzaStore();
        PizzaStore chicagoStore = new ChicagoPizzaStore();

        // we use one store to make Ethan's order...
        Pizza pizza = nyStore.OrderPizza("cheese");
        Console.WriteLine("Ethan ordered a " + pizza.GetName() + '\n');

        // ... and the other for Joel's
        pizza = chicagoStore.OrderPizza("cheese");
        Console.WriteLine("Joel ordered a " + pizza.GetName() + '\n');

        // both pizzas get prepared, the toppings get aded, and the pizzas are
        // baked, cut, and boxeed. our superclass never had to know the details;
        // the subclass handled all that just by instantiating the right pizza

        pizza = nyStore.OrderPizza("clam");
        Console.WriteLine("Ethan ordered a " + pizza.GetName() + '\n');

        pizza = chicagoStore.OrderPizza("clam");
        Console.WriteLine("Joel ordered a " + pizza.GetName() + '\n');

        pizza = nyStore.OrderPizza("pepperoni");
        Console.WriteLine("Ethan ordered a " + pizza.GetName() + '\n');

        pizza = chicagoStore.OrderPizza("pepperoni");
        Console.WriteLine("Joel ordered a " + pizza.GetName() + '\n');

        pizza = nyStore.OrderPizza("veggie");
        Console.WriteLine("Ethan ordered a " + pizza.GetName() + '\n');

        pizza = chicagoStore.OrderPizza("veggie");
        Console.WriteLine("Joel ordered a " + pizza.GetName() + '\n');
    }
}


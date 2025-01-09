namespace FactoryPattern;

public class PizzaTestDrive {
    static void Main(string[] args) {
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
    }
}


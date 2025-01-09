namespace simpleFactory;

public class PizzaTestDrive {
    static void Main() {
        SimplePizzaFactory factory = new();
        PizzaStore store = new(factory);

        Pizza pizza = store.OrderPizza("cheese");
        Console.WriteLine("We ordered a " + pizza.GetName() + "\n");
        Console.WriteLine(pizza);

        pizza = store.OrderPizza("veggie");
        Console.WriteLine("We ordered a " + pizza.GetName() + "\n");
        Console.WriteLine(pizza);
    }
}

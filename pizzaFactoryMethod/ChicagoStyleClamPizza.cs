namespace factoryMethod;

public class ChicagoStyleClamPizza : Pizza {
    public ChicagoStyleClamPizza() {
        name = "Chicago Style Clam Pizza";
        dough = "Extra Thick Crust Dough";
        sauce = "Plum Tomato Sauce";

        toppings.Add("Shredded Mozzarella Cheese");
        toppings.Add("Frozen Clams from Chesapeake Bay");
    }

    public override void Cut() {
        Console.WriteLine("Cutting the pizza into square slices");
    }
}

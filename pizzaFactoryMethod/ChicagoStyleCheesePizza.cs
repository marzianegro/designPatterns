﻿namespace factoryMethod;

public class ChicagoStyleCheesePizza : Pizza {
    public ChicagoStyleCheesePizza() {
        // the Chicago Pizza uses plm tomatoes as a sauce along with extra-thick crust
        name = "Chicago Style Deep Dish Cheese Pizza";
        dough = "Extra Thick Crust Dough";
        sauce = "Plum Tomato Sauce";

        // the Chicago-style deep dish pizza has lots of mozzarella cheese!
        toppings.Add("Shredded Mozzarella Cheese");
    }

    // the Chicago-style pizza also overrides the Cut() method so
    // that the pieces are cut into squares
    public override void Cut() {
        Console.WriteLine("Cuttin the pizza into square slices");
    }
}

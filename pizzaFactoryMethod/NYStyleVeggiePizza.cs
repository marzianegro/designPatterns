﻿namespace factoryMethod;

public class NYStyleVeggiePizza : Pizza {
    public NYStyleVeggiePizza() {
        name = "NY Style Veggie Pizza";
        dough = "Thin Crust Dough";
        sauce = "Marinara Sauce";

        toppings.Add("Grated Reggiano Cheese");
        toppings.Add("Garlic");
        toppings.Add("Onion");
        toppings.Add("Mushrooms");
        toppings.Add("Red Pepper");
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern;

public class NYStyleCheesePizza : Pizza {
    public NYStyleCheesePizza() {
        // the NY Pizza has its own marinara-style sauce and thin crust
        name = "NY Style Sauce and Cheese Pizza";
        dough = "Thin Crust Dough";
        sauce = "Marinara Sauce";

        // and one topping, Reggiano cheese!
        toppings.Add("Grated Reggiano Cheese");
    }
}

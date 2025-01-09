using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactoryPattern;

namespace simpleFactory;

public class PepperoniPizza : Pizza {
    public PepperoniPizza() {
        name = "Pepperoni Pizza";
        dough = "Crust";
        sauce = "Marinara sauce";
        toppings.Add("Sliced Pepperoni");
        toppings.Add("Sliced Onion");
        toppings.Add("Grated parmesan cheese");
    }
}

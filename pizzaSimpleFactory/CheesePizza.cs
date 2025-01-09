using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern;

// there are our *concrete products*.
// each product needs to implement the Pizza interface (which in this case means
// "extend the abstract Pizza class") and be concrete. as long as that's the case,
// it can be created by the factory and handed back to the client
public class CheesePizza : Pizza {
    public CheesePizza() {
        name = "Cheese Pizza";
        dough = "Regular Crust";
        sauce = "Marinara Pizza Sauce";
        toppings.Add("Fresh Mozzarella");
        toppings.Add("Parmesan");
    }
}

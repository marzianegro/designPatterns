using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern;

// this is the *product* of the factory: pizza!

// we've defined Pizza as an abstract class with some helpful
// implementations that can be overridden

// we'll start with an abstract Pizza class, and all the
// concrete pizzas will derive from this
public abstract class Pizza {
    // each Pizza has a name, a type of dough, a type of sauce,
    // and a set of toppings
    protected string name;
    protected string dough;
    protected string sauce;
    protected List<string> toppings = new();

    public string GetName() {
        return name;
    }

    public Pizza() { }

    // preparation follows a number of steps in a particular sequence
    public void Prepare() {
        Console.WriteLine("Preparing " + name);
        Console.WriteLine("Tossing dough...");
        Console.WriteLine("Adding sauce...");
        Console.WriteLine("Adding toppings: ");
        foreach (string topping in toppings) {
            Console.Write("   " + topping);
        }
    }

    // the abstract class provides some basic defaults for baking, cutting, and boxing
    public void Bake() {
        Console.Write("Bake for 25 minutes at 350");
    }

    public void Cut() {
        Console.Write("Cutting the pizza into diagonal slices");
    }

    public void Box() {
        Console.Write("Place pizza in official PizzaStore box");
    }

    public override string ToString() {
        StringBuilder display = new();
        display.Append("---- " + name + " ----\n");
        display.Append(dough + "\n");
        display.Append(sauce + "\n");
        foreach (string topping in toppings) {
            display.Append(topping + "\n");
        }
        return display.ToString();
    }
}

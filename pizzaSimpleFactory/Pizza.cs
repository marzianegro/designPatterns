using System.Text;

namespace simpleFactory;

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

    public void Prepare() {
        Console.WriteLine("Preparing " + name);
    }

    public void Bake() {
        Console.WriteLine("Baking " + name);
    }

    public void Cut() {
        Console.WriteLine("Cutting " + name);
    }

    public void Box() {
        Console.WriteLine("Boxing " + name);
    }

    public override string ToString() {
        // display pizza name and ingredients
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
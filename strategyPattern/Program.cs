namespace strategyPattern;

public class MiniDuckSimulator {
    public static void Main() {
        Duck mallard = new MallardDuck();

        // this calls the MallardDuck's inherited PerformQuack() method, which then delegates
        // to the object's QuackBehavior (i.e, calls Quack() on the duck's inherited QuackBehavior reference)
        mallard.PerformQuack();
        // then we do the same thing with MallardDuck's inherited PerformFly() method
        mallard.PerformFly();

        Duck model = new ModelDuck();
        // the first call to PerformFly() delegates to the flyBehavior object set in the ModelDuck's constructor, which is a FlyNoWay instance
        model.PerformFly();
        // this invokes the model's inherited behavior setter method, and... voilà!
        // the model suddenly has rocket-powered flying capability!
        model.SetFlyBehavior(new FlyRocketPowered());
        // if it worked, the model duck dynamically changed its flying behavior!
        // you can't do THAT if the implementation lives inside the Duck class
        model.PerformFly();
    }
}

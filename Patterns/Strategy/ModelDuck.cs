namespace Patterns.Strategy;

public class ModelDuck() : Duck(new FlyNoWayBehavior(), new QuackBehavior())
{
    public override void Display()
    {
        Console.WriteLine("I'm a ModelDuck");
    }
}
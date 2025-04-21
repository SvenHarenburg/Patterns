namespace Patterns.Strategy;

public class MallardDuck() : Duck(new FlyWithWingsBehavior(), new QuackBehavior())
{
    public override void Display()
    {
        Console.WriteLine("I'm a real Mallard duck");
    }
}
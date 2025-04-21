namespace Patterns.Strategy;

public class FlyNoWayBehavior : IFlyBehavior
{
    public void Fly()
    {
        Console.WriteLine("I can't fly");
    }
}
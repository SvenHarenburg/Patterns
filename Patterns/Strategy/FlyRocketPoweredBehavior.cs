namespace Patterns.Strategy;

public class FlyRocketPoweredBehavior : IFlyBehavior
{
    public void Fly()
    {
        Console.WriteLine("I'm flying with a rocket!");
    }
}
namespace Patterns.Strategy;

public class SqueakBehavior : IQuackBehavior
{
    public void Quack()
    {
        Console.WriteLine("Squeak");
    }
}
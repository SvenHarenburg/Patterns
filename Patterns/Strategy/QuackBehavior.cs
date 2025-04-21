namespace Patterns.Strategy;

public class QuackBehavior : IQuackBehavior
{
    public void Quack()
    {
        Console.WriteLine("Quack");
    }
}
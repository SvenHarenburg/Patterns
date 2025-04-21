namespace Patterns.Strategy;

public class MuteBehavior : IQuackBehavior
{
    public void Quack()
    {
        Console.WriteLine("<<Silence>>");
    }
}
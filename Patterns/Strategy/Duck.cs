namespace Patterns.Strategy;

public abstract class Duck(IFlyBehavior flyBehavior, IQuackBehavior quackBehavior)
{
    private IFlyBehavior flyBehavior = flyBehavior;
    private IQuackBehavior quackBehavior = quackBehavior;

    public abstract void Display();

    public void PerformFly()
    {
        flyBehavior.Fly();
    }

    public void PerformQuack()
    {
        quackBehavior.Quack();
    }

    public void Swim()
    {
        Console.WriteLine("All ducks float, even decoys!");
    }

    public void SetFlyBehavior(IFlyBehavior newFlyBehavior)
    {
        flyBehavior = newFlyBehavior;
    }

    public void SetQuackBehavior(IQuackBehavior newQuackBehavior)
    {
        quackBehavior = newQuackBehavior;
    }
}
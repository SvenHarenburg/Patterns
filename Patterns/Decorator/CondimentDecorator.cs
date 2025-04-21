namespace Patterns.Decorator;

public abstract class CondimentDecorator(Beverage decoratedBeverage) : Beverage
{
    protected Beverage Beverage { get; } = decoratedBeverage;

    public override Size GetSize()
    {
        return decoratedBeverage.GetSize();
    }
}
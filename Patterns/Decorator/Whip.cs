namespace Patterns.Decorator;

public class Whip(Beverage decoratedBeverage) : CondimentDecorator(decoratedBeverage)
{
    public override decimal Cost()
    {
        return Beverage.Cost() + .10m;
    }

    public override string GetDescription()
    {
        return Beverage.GetDescription() + ", Whip";
    }
}
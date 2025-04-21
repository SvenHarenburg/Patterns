namespace Patterns.Decorator;

public class Soy(Beverage decoratedBeverage) : CondimentDecorator(decoratedBeverage)
{
    public override decimal Cost()
    {
        return Beverage.Cost() + .15m;
    }

    public override string GetDescription()
    {
        return Beverage.GetDescription() + ", Soy";
    }
}
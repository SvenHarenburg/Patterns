namespace Patterns.Decorator;

public class Mocha(Beverage decoratedBeverage) : CondimentDecorator(decoratedBeverage)
{
    private readonly Dictionary<Size, decimal> priceMap = new()
    {
        { Size.Tall, .10m },
        { Size.Grande, .15m },
        { Size.Venti, .20m }
    };

    public override decimal Cost()
    {
        return Beverage.Cost() + priceMap[GetSize()];
    }

    public override string GetDescription()
    {
        return Beverage.GetDescription() + ", Mocha";
    }
}
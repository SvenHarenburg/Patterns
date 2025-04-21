namespace Patterns.Decorator;

public class HouseBlend : Beverage
{
    public HouseBlend()
    {
        Description = "House Blend Coffee";
    }

    public override decimal Cost()
    {
        return .89m;
    }
}
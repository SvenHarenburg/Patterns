namespace Patterns.Decorator;

public class DarkRoast : Beverage
{
    public DarkRoast()
    {
        Description = "Dark Roast Coffee";
    }

    public override decimal Cost()
    {
        return .99m;
    }
}
namespace Patterns.Decorator;

public class Espresso : Beverage
{
    public Espresso()
    {
        Description = "Espresso";
    }

    public override decimal Cost()
    {
        return 1.99m;
    }
}
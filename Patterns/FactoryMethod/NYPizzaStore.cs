namespace Patterns.FactoryMethod;

public class NYPizzaStore : PizzaStore
{
    protected override Pizza? CreatePizza(string type)
    {
        if (type == "cheese")
        {
            return new NYStyleCheesePizza();
        }

        // more types
        return null;
    }
}
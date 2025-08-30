namespace Patterns.FactoryMethod;

public class ChicagoPizzaStore : PizzaStore
{
    protected override Pizza? CreatePizza(string type)
    {
        if (type == "cheese")
        {
            return new ChicagoStyleCheesePizza();
        }

        // more types
        return null;
    }
}
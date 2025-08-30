namespace Patterns.FactoryMethod;

public abstract class PizzaStore
{
    protected abstract Pizza? CreatePizza(string type);

    public Pizza? OrderPizza(string type)
    {
        Pizza? pizza = null;
        pizza = CreatePizza(type);

        pizza.Prepare();
        pizza.Bake();
        pizza.Cut();
        pizza.Box();

        return pizza;
    }
}
namespace Patterns.FactoryMethod;

public class Pizza
{
    protected readonly List<string> toppings = new();
    protected string dough;
    protected string name;
    protected string sauce;

    public void Prepare()
    {
        Console.WriteLine($"Preparing {name}");
        Console.WriteLine("Tossing dough...");
        Console.WriteLine("Adding sauve...");
        Console.WriteLine("Adding toppings...");
        foreach (var topping in toppings)
        {
            Console.WriteLine($"    {topping}");
        }
    }

    public void Bake()
    {
        Console.WriteLine("Bake for 25 minutes at 350");
    }

    public virtual void Cut()
    {
        Console.WriteLine("Cutting the pizza into diagonal slices");
    }

    public void Box()
    {
        Console.WriteLine("Place pizza in official PizzaStore box");
    }

    public string GetName()
    {
        return name;
    }
}
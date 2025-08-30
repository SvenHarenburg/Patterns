using Patterns.FactoryMethod;

namespace Patterns.Tests.FactoryMethod;

public class Test
{
    [Test]
    public void Demo()
    {
        var nyStore = new NYPizzaStore();
        var chicagoStore = new ChicagoPizzaStore();

        var nyPizza = nyStore.OrderPizza("cheese");
        Console.WriteLine($"Someone ordered a {nyPizza?.GetName()}");
        
        var chicagoPizza = chicagoStore.OrderPizza("cheese");
        Console.WriteLine($"Someone ordered a {chicagoPizza?.GetName()}"); 
    }
}
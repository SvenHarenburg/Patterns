using Patterns.Decorator;

namespace Patterns.Tests.Decorator;

public class Tests
{
    [Test]
    public void Demo_Espresso()
    {
        var beverage = new Espresso();
        
        Assert.That(beverage.GetDescription(), Is.EqualTo("Espresso"));
        Assert.That(beverage.Cost(), Is.EqualTo(1.99m));
    }

    [Test]
    public void Demo_DarkRoastWithCondiments()
    {
        Beverage beverage = new DarkRoast();
        beverage = new Mocha(beverage);
        beverage = new Mocha(beverage);
        beverage = new Whip(beverage);
        
        Assert.That(beverage.GetDescription(), Is.EqualTo("Dark Roast Coffee, Mocha, Mocha, Whip"));
        Assert.That(beverage.Cost(), Is.EqualTo(1.49m));
    }

    [Test]
    public void Demo_HouseBlendWithCondiments()
    {
        Beverage beverage = new HouseBlend();
        beverage = new Soy(beverage);
        beverage = new Mocha(beverage);
        beverage = new Whip(beverage);
        
        Assert.That(beverage.GetDescription(), Is.EqualTo("House Blend Coffee, Soy, Mocha, Whip"));
        Assert.That(beverage.Cost(), Is.EqualTo(1.34m));
    }

    [Test]
    public void Demo_MochaIsPricedAccordingToSize()
    {
        Beverage tallBeverage = new HouseBlend();
        tallBeverage.SetSize(Beverage.Size.Tall);
        tallBeverage = new Mocha(tallBeverage);
        Assert.That(tallBeverage.Cost(), Is.EqualTo(.99m));
        
        Beverage grandeBeverage = new HouseBlend();
        grandeBeverage.SetSize(Beverage.Size.Grande);
        grandeBeverage = new Mocha(grandeBeverage);
        Assert.That(grandeBeverage.Cost(), Is.EqualTo(1.04m));
        
        Beverage ventiBeverage = new HouseBlend();
        ventiBeverage.SetSize(Beverage.Size.Venti);
        ventiBeverage = new Mocha(ventiBeverage);
        Assert.That(ventiBeverage.Cost(), Is.EqualTo(1.09m));
    }
}
using Patterns.Strategy;

namespace Patterns.Tests.Strategy;

public class Tests
{
    [Test]
    public void MallardDuck()
    {
        Duck mallardDuck = new MallardDuck();
        mallardDuck.PerformFly();
        mallardDuck.PerformQuack();
    }

    [Test]
    public void ModelDuck()
    {
        Duck duck = new ModelDuck();
        duck.PerformFly();
        duck.SetFlyBehavior(new FlyRocketPoweredBehavior());
        duck.PerformFly();
    }
}
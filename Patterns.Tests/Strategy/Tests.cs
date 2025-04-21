using Patterns.Strategy;

namespace Patterns.Tests.Strategy;

public class Tests
{
    [Test]
    public void MallardDuckDemo()
    {
        Duck mallardDuck = new MallardDuck();
        mallardDuck.PerformFly();
        mallardDuck.PerformQuack();
    }

    [Test]
    public void ModelDuckDemo()
    {
        Duck duck = new ModelDuck();
        duck.PerformFly();
        duck.SetFlyBehavior(new FlyRocketPoweredBehavior());
        duck.PerformFly();
    }
}
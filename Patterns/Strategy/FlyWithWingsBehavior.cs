﻿namespace Patterns.Strategy;

public class FlyWithWingsBehavior : IFlyBehavior
{
    public void Fly()
    {
        Console.WriteLine("I'm flying!!");
    }
}
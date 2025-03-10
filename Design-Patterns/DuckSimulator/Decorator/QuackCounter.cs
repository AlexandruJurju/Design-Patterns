﻿namespace DuckSimulator.Decorator;

public class QuackCounter : IQuackable
{
    private readonly IQuackable _duck;
    public static int NumberOfQuacks { get; private set; }

    public QuackCounter(IQuackable duck)
    {
        _duck = duck;
    }

    public void Quack()
    {
        _duck.Quack();
        NumberOfQuacks++;
    }
}
﻿using Bridge.Implementation;

namespace Bridge.Abstraction;

public class Abstraction
{
    protected IImplementation _implementation;

    public Abstraction(IImplementation implementation)
    {
        _implementation = implementation;
    }

    public virtual string Operation()
    {
        return "Abstract: Base operation with:\n" + _implementation.OperationImplementation();
    }
}
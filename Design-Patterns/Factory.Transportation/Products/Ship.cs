﻿namespace Factory.Transportation.Products;

public class Ship : ITransport
{
    public string Deliver()
    {
        return "Ship Transportation";
    }
}
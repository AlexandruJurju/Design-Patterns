﻿namespace Builder.FluentAction;

public class Address
{
    public string Street { get; init; } = null!;
    public string City { get; init; }= null!;
    public string Zip { get; init; }= null!;
    public string State { get; init; }= null!;
    public string Country { get; init; }= null!;
}
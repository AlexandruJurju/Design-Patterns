namespace Decorator.Starbuzz.Components;

public abstract class Beverage
{
    public virtual string Description { get; protected set; } = "Unknown beverage";
    
    public abstract double Cost();
}
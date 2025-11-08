namespace Flyweight.Dometrain.Conceptual;

public class ConcreteFlyweight(string intrinsicState) : IFlyweight
{
    private readonly string _intrinsicState =  intrinsicState;

    public void Operation(string extrinsicState)
    {
        Console.WriteLine($"Concrete Flyweight: intrinsic state {_intrinsicState}, extrinsic state {extrinsicState}");
    }
}
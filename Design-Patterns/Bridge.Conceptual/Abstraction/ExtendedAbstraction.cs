using Bridge.Conceptual.Implementation;

namespace Bridge.Conceptual.Abstraction;

public class ExtendedAbstraction(IImplementation implementation) : Abstraction(implementation)
{
    public override string Operation()
    {
        return "ExtendedAbstraction: Extended operation with:\n" + _implementation.OperationImplementation();
    }
}
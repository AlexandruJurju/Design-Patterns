namespace Adapter.Dometrain.Conceptual;

public class Adapter(Adaptee adaptee) : ITarget
{
    public void Request()
    {
        adaptee.SpecificRequest();
    }
}
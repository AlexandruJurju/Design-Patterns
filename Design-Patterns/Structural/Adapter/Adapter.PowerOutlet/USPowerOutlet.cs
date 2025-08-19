namespace Adapter.PowerOutlet;

public class USPowerOutlet
{
    public void ProvidePower(int voltage)
    {
        Console.WriteLine("Supplying 110V from a US power outlet.");
    }
}
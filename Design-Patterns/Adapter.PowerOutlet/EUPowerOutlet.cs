namespace Adapter.PowerOutlet;

public class EUPowerOutlet : IPowerOutlet
{
    public void SupplyPower(int voltage)
    {
        Console.WriteLine("Supplying 220V from an EU power outlet.");
    }
}

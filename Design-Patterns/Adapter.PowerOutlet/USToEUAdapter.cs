namespace Adapter.PowerOutlet;

public class USToEUAdapter : IPowerOutlet
{
    private readonly USPowerOutlet _usPowerOutlet;

    public USToEUAdapter(USPowerOutlet usPowerOutlet)
    {
        _usPowerOutlet = usPowerOutlet;
    }

    public void SupplyPower(int voltage)
    {
        int convertedVoltage = ConvertVoltage(220, 110);

        _usPowerOutlet.ProvidePower(convertedVoltage);

        Console.WriteLine($"Adapter converted 220V to 110V for the US power outlet.");
    }
    
    private int ConvertVoltage(int inputVoltage, int outputVoltage)
    {
        Console.WriteLine($"Converting {inputVoltage}V to {outputVoltage}V.");
        return outputVoltage;
    }
}
namespace Facade.Dometrain.Casting;

public class DeviceExplorer
{
    public async Task<IDevice> GetAsync(Guid deviceId)
    {
        Console.WriteLine($"Getting {deviceId}");

        return new SmartTVDevice();
    }
}
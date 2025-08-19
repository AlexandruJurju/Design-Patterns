namespace Decorator.EncryptStream.Components;

public class CloudStreamSender : CloudStream
{
    public override void Send(string data)
    {
        Console.WriteLine($"Sending data: {data}");
    }
}
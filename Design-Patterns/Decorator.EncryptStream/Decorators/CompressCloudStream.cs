using Decorator.EncryptStream.Components;

namespace Decorator.EncryptStream.Decorators;

public class CompressCloudStream : Decorator
{
    public CompressCloudStream(CloudStream decoratedStream) : base(decoratedStream)
    {
    }

    public override void Send(string data)
    {
        var compressed = Compress(data);
        _decoratedStream.Send(compressed);
    }

    private string Compress(string data)
    {
        return data.Substring(0, data.Length / 2);
    }
}
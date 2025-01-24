using Decorator.EncryptStream.Components;

namespace Decorator.EncryptStream.Decorators;

public abstract class Decorator : CloudStream
{
    protected CloudStream _decoratedStream;

    protected Decorator(CloudStream decoratedStream)
    {
        _decoratedStream = decoratedStream;
    }
}
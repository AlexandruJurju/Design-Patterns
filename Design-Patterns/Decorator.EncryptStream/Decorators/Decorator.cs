using Decorator.EncryptStream.Components;

namespace Decorator.EncryptStream.Decorators;

public abstract class Decorator(CloudStream decoratedStream) : CloudStream
{
    protected readonly CloudStream _decoratedStream = decoratedStream;
}
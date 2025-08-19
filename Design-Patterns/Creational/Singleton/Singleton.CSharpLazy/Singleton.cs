namespace Singleton.CSharpLazy;

internal sealed class Singleton
{
    private static readonly Lazy<Singleton> lazy = new(() => new Singleton());

    private Singleton()
    {
        Console.WriteLine("Constructor called");
    }

    public static Singleton Instance => lazy.Value;
}
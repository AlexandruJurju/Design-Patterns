namespace Singleton.CSharpLazy;

internal class Singleton
{
    private static readonly Lazy<Singleton> Lazy = new(() => new Singleton());

    private Singleton()
    {
        Console.WriteLine("Constructor called");
    }

    public static Singleton Instance => Lazy.Value;
}
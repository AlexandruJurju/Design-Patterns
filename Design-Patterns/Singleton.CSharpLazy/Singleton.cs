namespace Singleton.CSharpLazy;

sealed class Singleton
{
    private static readonly Lazy<Singleton> lazy = new(() => new Singleton());

    public static Singleton Instance
    {
        get { return lazy.Value; }
    }

    private Singleton()
    {
        Console.WriteLine("Constructor called");
    }
}
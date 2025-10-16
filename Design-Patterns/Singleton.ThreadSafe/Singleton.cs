namespace Singleton.ThreadSafe;

internal sealed class Singleton
{
    private static Singleton? _instance;
    private static readonly object _lock = new();

    private Singleton()
    {
        Console.WriteLine("Constructor");
    }

    public static Singleton Instance
    {
        get
        {
            lock (_lock)
            {
                if (_instance is null) _instance = new Singleton();
            }

            return _instance;
        }
    }
}
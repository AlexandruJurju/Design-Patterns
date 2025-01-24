namespace Singleton.ThreadSafe;

sealed class Singleton
{
    private static Singleton? _instance = null!;
    private static object _lock = new();

    public static Singleton Instance
    {
        get
        {
            lock (_lock)
            {
                if (_instance is null)
                {
                    _instance = new();
                }
            }

            return _instance;
        }
    }

    private Singleton()
    {
        Console.WriteLine("Constructor");
    }
}
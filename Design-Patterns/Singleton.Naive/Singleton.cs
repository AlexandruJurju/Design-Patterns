namespace Singleton.Naive;

// Not thread safe
// If multiple threads try to get the instance AT THE SAME TIME they will see that it's null and create a new instance
internal sealed class Singleton
{
    private static Singleton? _instance;

    private Singleton()
    {
        Console.WriteLine("Constructor");
    }

    public static Singleton Instance
    {
        get
        {
            if (_instance is null)
            {
                _instance = new Singleton();
            }

            return _instance;
        }
    }
}
namespace Proxy.Conceptual;

public class Proxy(ExpensiveService expensiveService) : IService
{
    public void Request()
    {
        if (!CheckAccess())
            return;

        expensiveService.Request();
        LogAccess();
    }

    private bool CheckAccess()
    {
        Console.WriteLine("Proxy: Checking access prior to firing a real request");

        return true;
    }

    private void LogAccess()
    {
        Console.WriteLine("Proxy: Logging the time of request");
    }
}
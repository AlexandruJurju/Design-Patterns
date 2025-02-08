namespace Proxy;

public class Proxy : IService
{
    private readonly ExpensiveService _expensiveService;

    public Proxy(ExpensiveService expensiveService)
    {
        _expensiveService = expensiveService;
    }
    
    public void Request()
    {
        if (CheckAccess())
        {
            _expensiveService.Request();
            LogAccess();
        }
    }
        
    public bool CheckAccess()
    {
        Console.WriteLine("Proxy: Checking access prior to firing a real request");

        return true;
    }
        
    public void LogAccess()
    {
        Console.WriteLine("Proxy: Logging the time of request");
    }
}
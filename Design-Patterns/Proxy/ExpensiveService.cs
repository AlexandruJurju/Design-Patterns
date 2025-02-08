namespace Proxy;

public class ExpensiveService : IService
{
    public void Request()
    {
        Console.WriteLine("ExpensiveService: Handling Request");
    }
}
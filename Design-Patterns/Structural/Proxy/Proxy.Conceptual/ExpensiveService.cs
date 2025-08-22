namespace Proxy.Conceptual;

public class ExpensiveService : IService
{
    public void Request()
    {
        Console.WriteLine("ExpensiveService: Handling Request");
    }
}
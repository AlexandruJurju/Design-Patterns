namespace DuckSimulator.Ducks;

public class DuckCall : IQuackable
{
    public void Quack()
    {
        Console.WriteLine("Kwak");
    }
}
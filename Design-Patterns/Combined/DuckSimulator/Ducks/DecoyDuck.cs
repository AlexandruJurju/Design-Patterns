namespace DuckSimulator.Ducks;

public class DecoyDuck : IQuackable
{
    public void Quack()
    {
        Console.WriteLine("<< Silence >>");
    }
}
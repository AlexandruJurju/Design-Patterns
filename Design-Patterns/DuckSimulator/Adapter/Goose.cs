namespace DuckSimulator.Adapter;

public class Goose
{
    public void Honk()
    {
        Console.WriteLine("Honk");
    }

    public override string ToString()
    {
        return "Adapter";
    }
}
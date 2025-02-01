namespace Builder.Building;

public class Building
{
    public string Type { get; set; }
    public List<string> Features { get; } = new();

    public void Show()
    {
        Console.WriteLine($"Building Type: {Type}");
        Console.WriteLine("Features: " + string.Join(", ", Features));
        Console.WriteLine();
    }
}
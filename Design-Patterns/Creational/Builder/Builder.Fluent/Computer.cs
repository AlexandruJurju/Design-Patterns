namespace Builder.Fluent;

public class Computer
{
    public string CPU { get; set; } = null!;
    public string RAM { get; set; } = null!;
    public string HardDisk { get; set; } = null!;

    public override string ToString()
    {
        return $"CPU: {CPU}, RAM: {RAM}, Hard disk: {HardDisk}";
    }
}
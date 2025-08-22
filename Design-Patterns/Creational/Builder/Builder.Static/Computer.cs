namespace Builder.Static;

public class Computer
{
    public string Cpu { get; set; } = null!;
    public string Ram { get; set; } = null!;
    public string HardDisk { get; set; } = null!;

    public override string ToString()
    {
        return $"CPU: {Cpu}, RAM: {Ram}, Hard disk: {HardDisk}";
    }
}
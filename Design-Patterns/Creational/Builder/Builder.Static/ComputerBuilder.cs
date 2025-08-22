namespace Builder.Static;

// using Fluent Interface for method chaining
public class ComputerBuilder
{
    private readonly Computer _computer = new();

    public ComputerBuilder WithCpu(string cpu)
    {
        _computer.Cpu = cpu;
        return this;
    }

    public ComputerBuilder WithRam(string ram)
    {
        _computer.Ram = ram;
        return this;
    }

    public ComputerBuilder WithHardDisk(string hardDisk)
    {
        _computer.HardDisk = hardDisk;
        return this;
    }

    public Computer Build()
    {
        return _computer;
    }
}
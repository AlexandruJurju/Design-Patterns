namespace Builder.Fluent;

// using Fluent Interface for method chaining
public class ComputerBuilder
{
    private readonly Computer _computer = new();

    public ComputerBuilder WithCPU(string cpu)
    {
        _computer.CPU = cpu;
        return this;
    }

    public ComputerBuilder WithRAM(string ram)
    {
        _computer.RAM = ram;
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
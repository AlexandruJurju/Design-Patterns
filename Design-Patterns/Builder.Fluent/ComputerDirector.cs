namespace Builder.Fluent;

public class ComputerDirector
{
    public Computer MakeServer(ComputerBuilder builder)
    {
        return builder.WithCPU("Intel i9")
            .WithRAM("64GB")
            .WithHardDisk("6TB HDD")
            .Build();
    }

    public Computer MakeNormal(ComputerBuilder builder)
    {
        return builder.WithCPU("Intel i5")
            .WithRAM("16gb")
            .WithHardDisk("1TB HDD")
            .Build();
    }

    public Computer MakeGaming(ComputerBuilder builder)
    {
        return builder.WithCPU("Intel i7")
            .WithRAM("32gb")
            .WithHardDisk("2TB SSD")
            .Build();
    }
}
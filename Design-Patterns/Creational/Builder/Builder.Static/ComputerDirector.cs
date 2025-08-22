namespace Builder.Static;

public class ComputerDirector
{
    public Computer MakeServer(ComputerBuilder builder)
    {
        return builder.WithCpu("Intel i9")
            .WithRam("64GB")
            .WithHardDisk("6TB HDD")
            .Build();
    }

    public Computer MakeNormal(ComputerBuilder builder)
    {
        return builder.WithCpu("Intel i5")
            .WithRam("16gb")
            .WithHardDisk("1TB HDD")
            .Build();
    }

    public Computer MakeGaming(ComputerBuilder builder)
    {
        return builder.WithCpu("Intel i7")
            .WithRam("32gb")
            .WithHardDisk("2TB SSD")
            .Build();
    }
}
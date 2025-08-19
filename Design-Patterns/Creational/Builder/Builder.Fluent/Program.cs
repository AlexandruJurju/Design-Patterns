using Builder.Fluent;

// using Fluent Interfaces and method chaining
var customComputer = new ComputerBuilder()
    .WithCPU("Intel i7")
    .WithRAM("16GB")
    .WithHardDisk("512GB SSD")
    .Build();
Console.WriteLine(customComputer);

// using a director
var director = new ComputerDirector();
var builder = new ComputerBuilder();

var server = director.MakeServer(builder);
Console.WriteLine(server);

var gaming = director.MakeGaming(builder);
Console.WriteLine(gaming);
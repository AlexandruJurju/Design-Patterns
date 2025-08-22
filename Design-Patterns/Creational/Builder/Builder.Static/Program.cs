using Builder.Static;

// using Fluent Interfaces and method chaining
var customComputer = new ComputerBuilder()
    .WithCpu("Intel i7")
    .WithRam("16GB")
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
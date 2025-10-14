using AbstractFactory.Furniture.AbstractFactories;

IAbstractFactory modernFactory = new ModernFurnitureFactory();
var modernChair = modernFactory.CreateChair();
var modernCouch = modernFactory.CreateCouch();
var modernTable = modernFactory.CreateTable();

Console.WriteLine(modernChair.Sit());
Console.WriteLine(modernCouch.WatchTV());
Console.WriteLine(modernTable.Eat());
Console.WriteLine();


IAbstractFactory victorianFactory = new VictorianFurnitureFactory();
var victorianChair = victorianFactory.CreateChair();
var victorianCouch = victorianFactory.CreateCouch();
var victorianTable = victorianFactory.CreateTable();

Console.WriteLine(victorianChair.Sit());
Console.WriteLine(victorianCouch.WatchTV());
Console.WriteLine(victorianTable.Eat());
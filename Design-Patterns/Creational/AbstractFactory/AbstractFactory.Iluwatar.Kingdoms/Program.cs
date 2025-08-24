using AbstractFactory.Iluwatar.Kingdoms;
using AbstractFactory.Iluwatar.Kingdoms.Factories;

IKingdomFactory humanKingdom = FactoryMaker.MakeFactory(FactoryMaker.KingdomType.Human);

Console.WriteLine(humanKingdom.CreateArmy().Description);
Console.WriteLine(humanKingdom.CreateCastle().Description);
Console.WriteLine(humanKingdom.CreateWeapons().Description);
Console.WriteLine();

IKingdomFactory dwarfKingdom = FactoryMaker.MakeFactory(FactoryMaker.KingdomType.Dwarf);
Console.WriteLine(dwarfKingdom.CreateArmy().Description);
Console.WriteLine(dwarfKingdom.CreateCastle().Description);
Console.WriteLine(dwarfKingdom.CreateWeapons().Description);
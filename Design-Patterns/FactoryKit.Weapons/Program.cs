// See https://aka.ms/new-console-template for more information

using FactoryKit.Weapons;

var itemFactory = ItemFactoryBuilder.CreateWeaponKit();

Console.WriteLine("Available items to craft:");
foreach (var itemType in itemFactory.GetAvailableItems()) Console.WriteLine($"- {itemType}");

var sword = itemFactory.CreateItem(nameof(WeaponType.Sword));
var axe = itemFactory.CreateItem(nameof(WeaponType.Axe));
var bow = itemFactory.CreateItem(nameof(WeaponType.Bow));
var spear = itemFactory.CreateItem(nameof(WeaponType.Spear));

Console.WriteLine(sword.Name);
Console.WriteLine(axe.Name);
Console.WriteLine(bow.Name);
Console.WriteLine(spear.Name);
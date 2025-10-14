using FactoryMethod.Iluwatar.Weapons.Factories;
using FactoryMethod.Iluwatar.Weapons.Products;

Blacksmith orcBlacksmith = new OrcBlacksmith();
orcBlacksmith.CraftWeapon(WeaponType.Sword).DisplayInfo();
orcBlacksmith.CraftWeapon(WeaponType.Bow).DisplayInfo();


Blacksmith elfBlacksmith = new ElfBlacksmith();
elfBlacksmith.CraftWeapon(WeaponType.Sword).DisplayInfo();
elfBlacksmith.CraftWeapon(WeaponType.Bow).DisplayInfo();
using AbstractFactory.Iluwatar.Kingdoms.Products;
using AbstractFactory.Iluwatar.Kingdoms.Products.DwarfNation;

namespace AbstractFactory.Iluwatar.Kingdoms.Factories;

public class DwarfKingdomFactory : IKingdomFactory
{
    public IArmy CreateArmy()
    {
        return new DwarfArmy();
    }

    public IWeapons CreateWeapons()
    {
        return new DwarfWeapons();
    }

    public ICastle CreateCastle()
    {
        return new DwarfCastle();
    }
}
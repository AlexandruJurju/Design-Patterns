using AbstractFactory.Iluwatar.Kingdoms.Products;
using AbstractFactory.Iluwatar.Kingdoms.Products.HumanNation;

namespace AbstractFactory.Iluwatar.Kingdoms.Factories;

public class HumanKingdomFactory : IKingdomFactory
{
    public IArmy CreateArmy()
    {
        return new HumanArmy();
    }

    public IWeapons CreateWeapons()
    {
        return new HumanWeapons();
    }

    public ICastle CreateCastle()
    {
        return new HumanCastle();
    }
}
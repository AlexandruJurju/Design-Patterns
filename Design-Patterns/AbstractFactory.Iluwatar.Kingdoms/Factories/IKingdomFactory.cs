using AbstractFactory.Iluwatar.Kingdoms.Products;

namespace AbstractFactory.Iluwatar.Kingdoms.Factories;

public interface IKingdomFactory
{
    IArmy CreateArmy();
    IWeapons CreateWeapons();
    ICastle CreateCastle();
}
using AbstractFactory.Iluwatar.Kingdoms.Factories;

namespace AbstractFactory.Iluwatar.Kingdoms;

// deviation from pattern -> use an enum for the race to create the factories easier
public static class FactoryMaker
{
    public enum KingdomType
    {
        Human,
        Dwarf
    }

    public static IKingdomFactory MakeFactory(KingdomType type)
    {
        return type switch
        {
            KingdomType.Human => new HumanKingdomFactory(),
            KingdomType.Dwarf => new DwarfKingdomFactory(),
            _ => throw new ArgumentException($"Unknown kingdom type: {type}")
        };
    }
}
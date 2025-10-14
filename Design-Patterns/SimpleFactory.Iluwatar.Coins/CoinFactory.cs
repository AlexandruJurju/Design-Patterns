using SimpleFactory.Iluwatar.Coins.Products;

namespace SimpleFactory.Iluwatar.Coins;

public class CoinFactory
{
    public static ICoin CreateCoin(CoinType coinType)
    {
        return coinType switch
        {
            CoinType.Gold => new GoldCoin(),
            CoinType.Silver => new SilverCoin(),
            CoinType.Copper => new CopperCoin(),
            _ => throw new ArgumentException("Invalid coin type")
        };
    }
}
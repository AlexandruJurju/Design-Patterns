using SimpleFactory.Iluwatar.Coins;
using SimpleFactory.Iluwatar.Coins.Products;

ICoin goldCoin = CoinFactory.CreateCoin(CoinType.Gold);
goldCoin.Display();
ICoin silverCoin = CoinFactory.CreateCoin(CoinType.Silver);
silverCoin.Display();
ICoin copperCoin = CoinFactory.CreateCoin(CoinType.Copper);
copperCoin.Display();
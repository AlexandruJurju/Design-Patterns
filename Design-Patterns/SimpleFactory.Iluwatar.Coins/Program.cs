using SimpleFactory.Iluwatar.Coins;
using SimpleFactory.Iluwatar.Coins.Products;

var goldCoin = CoinFactory.CreateCoin(CoinType.Gold);
goldCoin.Display();
var silverCoin = CoinFactory.CreateCoin(CoinType.Silver);
silverCoin.Display();
var copperCoin = CoinFactory.CreateCoin(CoinType.Copper);
copperCoin.Display();
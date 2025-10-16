namespace SimpleFactory.Iluwatar.Coins.Products;

public class GoldCoin : ICoin
{
    public string Description => "Gold Coin";
    public decimal Value => 50.0m;

    public void Display()
    {
        Console.WriteLine($"{Description}: with value {Value}\n");
    }
}
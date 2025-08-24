namespace SimpleFactory.Iluwatar.Coins.Products;

public class SilverCoin : ICoin
{
    public string Description => "Silver Coin";
    public decimal Value => 5.0m;
    public void Display() =>  Console.WriteLine($"{Description}: with value {Value}\n");
}
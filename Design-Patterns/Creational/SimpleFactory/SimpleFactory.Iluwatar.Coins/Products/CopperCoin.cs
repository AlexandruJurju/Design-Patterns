namespace SimpleFactory.Iluwatar.Coins.Products;

public class CopperCoin : ICoin
{
    public string Description => "Copper Coin";
    public decimal Value => 1.0m;
    public void Display() =>  Console.WriteLine($"{Description}: with value {Value}\n");
}
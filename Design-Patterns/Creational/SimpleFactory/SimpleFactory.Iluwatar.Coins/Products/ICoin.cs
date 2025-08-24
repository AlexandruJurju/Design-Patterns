namespace SimpleFactory.Iluwatar.Coins.Products;

public interface ICoin
{
    string Description { get; }
    decimal Value { get; }
    void Display();
}
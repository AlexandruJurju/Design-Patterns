namespace Strategy.OrderNotifier;

public class Order
{
    public int Id { get; set; }
    public string CustomerEmail { get; set; } = null!;
    public string CustomerPhone { get; set; } = null!;
    public OrderStatus Status { get; set; }
    public DateTime ShippedAt { get; set; }
}